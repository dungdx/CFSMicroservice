using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Infrastructure.Core
{
    public class ObjectContainer
    {
        private static ObjectContainer _current;
        private static IinjectContainer _container;

        public static void ApplicationStart(IinjectContainer container)
        {
            _container = container;
            _current = new ObjectContainer(_container);
        }

        protected ObjectContainer(IinjectContainer inversion)
        {
            Container = inversion;
        }
        public static ObjectContainer Current 
        {
            get {
                if (_current == null)
                {
                    ApplicationStart(_container);
                }
                return _current;
            }        
        }
        protected IinjectContainer Container
        {
            get;
            set;
        }
        protected ObjectContainer()
        {
            Container = new DefaultContainerForDictionary();
        }

        public void RegisterType<T>()
        {
            Container.RegisterType<T>();
        }
        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
