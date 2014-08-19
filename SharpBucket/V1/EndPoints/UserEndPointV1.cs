﻿using System.Collections.Generic;
using SharpBucket.V1.Pocos;

namespace SharpBucket.V1.EndPoints{
    public class UserEndPointV1{
        private readonly SharpBucketV1 _sharpBucketV1;
        private readonly string _baseUrl;

        public UserEndPointV1(SharpBucketV1 sharpBucketV1){
            _sharpBucketV1 = sharpBucketV1;
            _baseUrl = "user/";
        }

        /// <summary>
        /// Get the current users info.
        /// </summary>
        /// <returns></returns>
        public UserInfo GetInfo(){
            return _sharpBucketV1.Get(new UserInfo(), _baseUrl);
        }

        public Privileges ListPrivileges(){
            var overrideUrl = _baseUrl + "privileges";
            return _sharpBucketV1.Get(new Privileges(), overrideUrl);
        }

        public List<Repository> ListFollows(){
            var overrideUrl = _baseUrl + "follows";
            return _sharpBucketV1.Get(new List<Repository>(), overrideUrl);
        }

        public List<Repository> ListRepositories(){
            var overrideUrl = _baseUrl + "repositories";
            return _sharpBucketV1.Get(new List<Repository>(), overrideUrl);
        }

        public RepositoriesOverview RepositoriesOverview(){
            var overrideUrl = _baseUrl + "repositories/overview";
            return _sharpBucketV1.Get(new RepositoriesOverview(), overrideUrl);
        }

        // TODO: Fix serialization
        public object GetRepositoryDasboard(){
            var overrideUrl = _baseUrl + "repositories/dashboard";
            return _sharpBucketV1.Get(new object(), overrideUrl);
        }
    }
}