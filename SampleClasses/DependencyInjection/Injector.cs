using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.DependencyInjection
{
    class Injector
    {
        public void Bind<TKey, TConcrete>() where TConcrete : TKey
        {

        }
        public void Bind<T>(T instance)
        {

        }

        //internal TKey Resolve<TKey>()
        //{

        //}
    }
}
