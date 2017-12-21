using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.Singleton
{
    /// <summary>
    /// Threadsafe, no locks.  Is not 'lazy'
    /// </summary>
    public class Singleton3
    {
        private static readonly Singleton3 instance = new Singleton3();
        //alternatively, can use this...  Only is in up to date frameworks
        private static readonly Lazy<Singleton3> lazy =
                new Lazy<Singleton3>(() => new Singleton3());

        static Singleton3() { }

        private Singleton3()
        {
            //stuff that must happen only once
        }
        public static Singleton3 Instance { get { return instance; } }


        public void DoSomething()
        {
            //Stuff
        }
    }
}
