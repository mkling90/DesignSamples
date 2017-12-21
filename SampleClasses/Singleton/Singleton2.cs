using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.Singleton
{
    /// <summary>
    /// Threadsafe version of simple Singleton
    /// </summary>
    class Singleton2
    {
        private static readonly object mutex = new object();
        private static Singleton2 instance;

        private Singleton2()
        {
            //stuff that must happen only once
        }

        public static Singleton2 Instance
        {
            get
            {
                if(instance == null)  //double checked locking
                {
                    lock (mutex)
                    {
                        if (instance == null)
                            instance = new Singleton2();
                    }        
                }
                return instance;
            }
        }

        public void DoSomething()
        {
            //Stuff here
        }
    }
}
