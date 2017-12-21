using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.Singleton
{
    /// <summary>
    /// True Lazy Loading, Threadsafe
    /// </summary>
    class Singleton4
    {
        //How to completely be lazy initialized
        private static class SingletonHolder
        {
            //Threadsafe already, static initializers are threadsafe
            internal static readonly Singleton4 instance = new Singleton4();
            //Empty static constructor - forces initialization laziness
            static SingletonHolder() { }
        }

        public static Singleton4 Instance { get { return SingletonHolder.instance; } }

        public void DoSomething()
        {
            //Stuff
        }

    }
}
