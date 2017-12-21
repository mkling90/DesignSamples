using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.Singleton
{
   /// <summary>
   /// Simple Singleton
   /// </summary>
    public class Singleton1
    {
        private static Singleton1 instance;
        private Singleton1()
        {
            //stuff that must happen only once
        }

        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton1();
                return instance;
            }
        }

        public void DoSomething()
        {
            //Doing important stuff here
        }
    }
}
