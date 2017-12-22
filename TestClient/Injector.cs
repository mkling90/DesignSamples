using SampleClasses.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Injector
    {
        public ConsoleLogService CreateLogService()
        {
            return new ConsoleLogService();
        }

        public OutlookEmailService CreateOutlookEmailService()
        {
            return new OutlookEmailService();
        }
        public Dependency1 CreateDependency1()
        {
            return new Dependency1(CreateLogService(), CreateOutlookEmailService());
        }
    }
}
