using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.Singleton
{
    public class Singleton3
    {
        //How to completely be lazy initialized
        private static class SingletonHolder
        {
            //Threadsafe already, static initializers are threadsafe
            internal static readonly Singleton3 instance = new Singleton3();
            //Empty static constructor - forces initialization laziness
            static SingletonHolder() { }
        }

        //Threadsafe already, static initializers are threadsafe
        //Move into the holder class for true laziness
        //private static readonly Singleton3 instance = new Singleton3();

        //Empty static constructor - forces initialization laziness
        //If there are static methods though, they will be initialized here
        //static Singleton3() { }
        
        private Singleton3()
        {
            //stuff that must happen only once
        }
        //public static Singleton3 Instance { get { return instance; } }
        public static Singleton3 Instance { get { return SingletonHolder.instance; } }

        public void DoSomething()
        {
            //Stuff
        }
    }
}
