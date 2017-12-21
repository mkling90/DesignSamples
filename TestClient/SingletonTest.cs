using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleClasses.Singleton;

namespace TestClient
{
    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void UseSingleton1()
        {
            Singleton1 s1 = Singleton1.Instance;
            Singleton1 s2 = Singleton1.Instance;
            NUnit.Framework.Assert.AreSame(s1, s2);
            s1.DoSomething();
        }
        [Test]
        public void UseSingleton3()
        {
            Singleton3 s1 = Singleton3.Instance;
            Singleton3 s2 = Singleton3.Instance;
            NUnit.Framework.Assert.AreSame(s1, s2);
            s1.DoSomething();
        }
    }
}
