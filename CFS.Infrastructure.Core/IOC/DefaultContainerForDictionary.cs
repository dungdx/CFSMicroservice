using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Infrastructure.Core
{
    public class DefaultContainerForDictionary : IinjectContainer
    {
        private static Dictionary<Type, object> _objectDefined = new Dictionary<Type, object>();
        public void RegisterType<T>()
        {
            if (!_objectDefined.ContainsKey(typeof(T)))
            {
                _objectDefined[typeof(T)] = Activator.CreateInstance(typeof(T));
            }
        }

        public T Resolve<T>()
        {
            if (_objectDefined.ContainsKey(typeof(T)))
            {
                return (T)_objectDefined[typeof(T)];
            }
            throw new Exception("Kiểu dịch vụ này không được đăng ký!");
        }
    }
}
