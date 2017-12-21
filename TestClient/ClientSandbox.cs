using SampleClasses.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    /// <summary>
    /// To demo usage without tests
    /// </summary>
    class ClientSandbox
    {
        public void UseDependency()
        {
            ConsoleLogService logSvc = new ConsoleLogService();
            OutlookEmailService emailSvc = new OutlookEmailService();
            Dependency1 dep = new Dependency1(logSvc, emailSvc);
            dep.DoStuff();
        }
    }
}
