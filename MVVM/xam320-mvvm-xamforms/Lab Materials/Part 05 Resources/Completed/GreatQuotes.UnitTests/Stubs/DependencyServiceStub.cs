using System;
using System.Collections.Generic;
using XamarinUniversity.Interfaces;

namespace GreatQuotes.UnitTests.Stubs
{
    public class DependencyServiceStub : IDependencyService
    {
        readonly Dictionary<Type, object> registeredServices = new Dictionary<Type, object>();

        public void Register<T>(object impl)
        {
            this.registeredServices[typeof(T)] = impl;
        }

        public T Get<T> () where T:class
        {
            return (T)registeredServices[typeof(T)];
        }
    }
}
