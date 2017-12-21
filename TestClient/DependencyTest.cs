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
            ConsoleLogService logSvc = new ConsoleLogService();
            OutlookEmailService emailSvc = new OutlookEmailService();
            Dependency1 dep = new Dependency1(logSvc, emailSvc);
            dep.DoStuff();
        }
    }
}
