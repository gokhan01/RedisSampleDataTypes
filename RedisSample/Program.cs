using RedisSample.Cache;
using RedisSample.Cache.Models;
using RedisSample.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICache redisCache = new RedisCache();
            RedisListCache redisCacheList = new RedisListCache();
            RedisHashCache redisHashCache = new RedisHashCache();

            ListOperations(redisCacheList);
            HashOperations(redisHashCache);

            Console.ReadKey();
        }

        private static void HashOperations(RedisHashCache redisHashCache)
        {
            string key = "hashDataType";
            ICache redisCache = new RedisCache();
            //redisCache.Delete(key);
            List<BankBranchModel> bankBranches = new List<BankBranchModel>();
            using (Model1 db = new Model1())
            {
                if (!redisCache.Exists(key))
                {
                    redisHashCache.HashBulkSet(key, db.BankBranch.Select(x => new BankBranchModel
                    {
                        BankCode = x.BankCode,
                        BankID = x.BankID,
                        BranchCityCode = x.BranchCityCode,
                        BranchCityName = x.BranchCityName,
                        BranchCode = x.BranchCode,
                        BranchName = x.BranchName,
                        BranchRegionCode = x.BranchRegionCode,
                        BranchRegionName = x.BranchRegionName,
                        ID = x.ID,
                        IsActive = x.IsActive,
                        IsDeleted = x.IsDeleted
                    }).ToList(), 5);
                }
            }
            bankBranches.AddRange(redisHashCache.HashGet<BankBranchModel>(key, "0046"));
        }

        private static void ListOperations(RedisListCache redisListCache)
        {
            string key = "gokhan";
            ICache redisCache = new RedisCache();
            //redisCache.Delete(key);
            List<BankBranch> bankBranches = new List<BankBranch>();
            using (Model1 db = new Model1())
            {
                if (!redisCache.Exists(key))
                {
                    redisListCache.RightBulkPush(key, db.BankBranch.ToList(), 5);
                }
            }
            bankBranches.AddRange(redisListCache.ListRange<BankBranch>(key));
        }
    }
}
