using CFS.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Infrastructure.Core.Strategies.CacheMgr
{
    public static class Cache
    {
        private static object cacheLocker = new object();//Ensure data only only one threat change.
        private static ICache cache = null;
               
        public delegate void DoSub(object d);

        static Cache()
        {
            Load();
        }

        private static void Load()
        {
            try
            {
                cache = ObjectContainer.Current.Resolve<ICache>();
            }
            catch (Exception e)
            {

            }
        }

        public static ICache GetCache()
        {
            return cache;
        }

        public static int TimeOut
        {
            get
            {
                return cache.TimeOut;
            }
            set
            {
                lock (cacheLocker)
                {
                    cache.TimeOut = value;
                }
            }
        }

        public static T Get<T>(string key)
        {
            return cache.Get<T>(key);
        }

        public static void Insert(string key, object data)
        {
            if (string.IsNullOrWhiteSpace(key) || data == null)
                return;
            //lock (cacheLocker)
            {
                cache.Insert(key, data);
            }
        }

        public static void Insert<T>(string key, T data)
        {
            if (string.IsNullOrWhiteSpace(key) || data == null)
                return;
            //lock (cacheLocker)
            {
                cache.Insert<T>(key, data);
            }
        }

        public static void Insert(string key, object data, int cacheTime)
        {
            if (!string.IsNullOrWhiteSpace(key) && data != null)
            {
                //lock (cacheLocker)
                {
                    cache.Insert(key, data, cacheTime);
                }
            }
        }

        public static void Insert<T>(string key, T data, int cacheTime)
        {
            if (!string.IsNullOrWhiteSpace(key) && data != null)
            {
                //lock (cacheLocker)
                {
                    cache.Insert<T>(key, data, cacheTime);
                }
            }
        }

        public static void Insert(string key, object data, DateTime cacheTime)
        {
            if (!string.IsNullOrWhiteSpace(key) && data != null)
            {
                //lock (cacheLocker)
                {
                    cache.Insert(key, data, cacheTime);
                }
            }
        }

        public static void Insert<T>(string key, T data, DateTime cacheTime)
        {
            if (!string.IsNullOrWhiteSpace(key) && data != null)
            {
                //lock (cacheLocker)
                {
                    cache.Insert<T>(key, data, cacheTime);
                }
            }
        }

        public static void Remove(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return;
            lock (cacheLocker)
            {
                cache.Remove(key);
            }
        }

        public static bool Exists(string key)
        {
            return cache.Exists(key);
        }

        public static void Send(string key, object data)
        {
            cache.Send(key, data);
        }
        public static void RegisterSubscribe<T>(string key, DoSub dosub)
        {
            cache.RegisterSubscribe<T>(key, dosub);
        }
        public static void UnRegisterSubscrib(string key)
        {
            cache.UnRegisterSubscrib(key);
        }

        public static ICacheLocker GetCacheLocker(string key)
        {
            return cache.GetCacheLocker(key);
        }

        public static bool SetNX(string key, string value)
        {
            return cache.SetNX(key, value);
        }

        public static bool SetNX(string key, string value, int cacheTime)
        {
            return cache.SetNX(key, value, cacheTime);
        }

        //public static void InsertLocal<T>(string key, T data, int cacheTime)
        //{
        //    Helper.Sgmall.Core.Helper.CacheHelper.Insert(key, data, cacheTime);
        //}

        //public static T GetLocal<T>(string key)
        //{
        //    return Helper.Sgmall.Core.Helper.CacheHelper.Get<T>(key);
        //}

    }
}
