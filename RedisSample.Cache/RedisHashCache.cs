using Newtonsoft.Json;
using RedisSample.Cache.Models;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSample.Cache
{
    public class RedisHashCache
    {
        private readonly IDatabase _redisDb;

        //Connection bilgisi initialize anında alınıyor
        public RedisHashCache()
        {
            _redisDb = RedisConnectionFactory.Connection.GetDatabase();
        }

        public void HashSet<T>(string key, T objectToCache, int cacheTime = 1)
            where T : BaseEntity
        {
            _redisDb.HashSet(key, objectToCache.BankCode, JsonConvert.SerializeObject(objectToCache));

            var expiresIn = TimeSpan.FromMinutes(cacheTime);

            if (cacheTime > 0)
                _redisDb.KeyExpire(key, expiresIn);
        }

        public void HashBulkSet<T>(string key, List<T> values, int cacheTime = 1)
            where T : BaseEntity
        {
            HashEntry[] hashEntries = values.GroupBy(x => x.BankCode).Select(x => new HashEntry(x.Key, JsonConvert.SerializeObject(x))).ToArray();

            _redisDb.HashSet(key, hashEntries);

            var expiresIn = TimeSpan.FromMinutes(cacheTime);

            if (cacheTime > 0)
                _redisDb.KeyExpire(key, expiresIn);
        }

        public List<T> HashGet<T>(string key, string valueKey)
        {
            return JsonConvert.DeserializeObject<List<T>>(_redisDb.HashGet(key, valueKey));
        }

        //Redis bağlantısını Dispose eden metot
        public void Dispose()
        {
            RedisConnectionFactory.Connection.Dispose();
        }
    }
}
