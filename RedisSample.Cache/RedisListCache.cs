using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSample.Cache
{
    public class RedisListCache
    {
        private readonly IDatabase _redisDb;

        //Connection bilgisi initialize anında alınıyor
        public RedisListCache()
        {
            _redisDb = RedisConnectionFactory.Connection.GetDatabase();
        }

        public void RightPush<T>(string key, T objectToCache, int cacheTime = 1)
        {
            _redisDb.ListRightPush(key, JsonConvert.SerializeObject(objectToCache));

            var expiresIn = TimeSpan.FromMinutes(cacheTime);

            if (cacheTime > 0)
                _redisDb.KeyExpire(key, expiresIn);
        }

        public void RightBulkPush<T>(string key, List<T> values, int cacheTime = 1)
        {
            _redisDb.ListRightPush(key, values.Select(x => (RedisValue)JsonConvert.SerializeObject(x)).ToArray());

            var expiresIn = TimeSpan.FromMinutes(cacheTime);

            if (cacheTime > 0)
                _redisDb.KeyExpire(key, expiresIn);
        }

        public void SetByIndex<T>(string key, long index, T objectToCache)
        {
            _redisDb.ListSetByIndex(key, index, JsonConvert.SerializeObject(objectToCache));
        }

        public List<T> GetByIndex<T>(string key, long start = 0, long stop = -1)
        {
            var list = JsonConvert.SerializeObject(_redisDb.ListRange(key, start, stop));
            return JsonConvert.DeserializeObject<List<T>>(list);
        }

        public List<T> ListRange<T>(string key, long start = 0, long stop = -1)
        {
            var items = _redisDb.ListRange(key, start, stop);
            //return JsonConvert.DeserializeObject<List<T>>(list);
            return items.Select(i => JsonConvert.DeserializeObject<T>(i)).ToList();
        }

        public T GetByIndex<T>(string key, long index)
        {
            return JsonConvert.DeserializeObject<T>(_redisDb.ListGetByIndex(key, index));
        }

        //Redis bağlantısını Dispose eden metot
        public void Dispose()
        {
            RedisConnectionFactory.Connection.Dispose();
        }
    }
}
