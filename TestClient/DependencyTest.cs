using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleClasses.DependencyInjection;

namespace TestClient
{
    [TestFixture]
    class DependencyTest
    {
        [Test]
        public void TestDependency1()
        {
            Injector depInjector = new Injector();
            Dependency1 dep = depInjector.CreateDependency1();
            dep.DoStuff();
        }
    }
}
