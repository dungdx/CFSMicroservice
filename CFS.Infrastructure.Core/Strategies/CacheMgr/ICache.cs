using System;
using System.Collections.Generic;
using System.Text;

namespace CFS.Infrastructure.Core.Strategies.CacheMgr
{
    public interface ICache: IStrategy
    {
        /// <summary>
        /// TimeOut
        /// </summary>
        int TimeOut { set; get; }

        /// <summary>
        /// Get
        /// </summary>
        T Get<T>(string key);

        /// <summary>
        /// Get
        /// </summary>
        object Get(string key);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);


        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        void Insert(string key, object data);

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        void Insert<T>(string key, T data);


        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="cacheTime"></param>
        void Insert(string key, object data, int cacheTime);

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="cacheTime"></param>
        void Insert<T>(string key, T data, int cacheTime);

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="cacheTime"></param>
        void Insert(string key, object data, DateTime cacheTime);

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="cacheTime"></param>
        void Insert<T>(string key, T data, DateTime cacheTime);

        /// <summary>
        /// SetNX
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        bool SetNX(string key, string value);

        /// <summary>
        /// SetNX
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="cacheTime"></param>
        /// <returns></returns>
        bool SetNX(string key, string value, int cacheTime);

        /// <summary>
        /// Send
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        void Send(string key, object data);


        /// <summary>
        /// Exists
        /// </summary>
        bool Exists(string key);

        /// <summary>
        /// RegisterSubscribe 
        /// </summary>
        void RegisterSubscribe<T>(string key, Cache.DoSub dosub);


        /// <summary>
        /// UnRegisterSubscrib
        /// </summary>
        void UnRegisterSubscrib(string key);


        /// <summary>
        /// GetCacheLocker
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        ICacheLocker GetCacheLocker(string key);
    }
}
