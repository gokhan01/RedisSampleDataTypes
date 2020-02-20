using System;

namespace RedisSample.Cache
{
    public interface ICache : IDisposable
    {
        T Get<T>(string key);

        void Set<T>(string key, T obj, DateTime expireDate);

        void Delete(string key);

        bool Exists(string key);
    }
}
