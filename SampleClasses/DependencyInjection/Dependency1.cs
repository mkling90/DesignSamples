using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.DependencyInjection
{
    public class Dependency1
    {
        private ILogService _loggerService;
        private IEmailService _emailService;
 

        public Dependency1(ILogService logService, IEmailService emailService)
        {
            _loggerService = logService;
            _emailService = emailService;
        }

        public void DoStuff()
        {
            _loggerService.WriteLog("Doing Stuff!");
            _emailService.SendEmail("All done");
        }
    }
}
