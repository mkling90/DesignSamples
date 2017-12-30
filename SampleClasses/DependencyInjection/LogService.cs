using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.DependencyInjection
{
    public enum LogType {
        Info, Warning, Error
    }
    public interface ILogService
    {
        void WriteLog(string message);
    }

    public class ConsoleLogService : ILogService
    {
        public ConsoleLogService(LogType logType)
        {
        }
        void ILogService.WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface IEmailService
    {
        void SendEmail(string message);
    }

    public class OutlookEmailService : IEmailService
    {
        public OutlookEmailService()
        {

        }
        void IEmailService.SendEmail(string message)
        {
            Console.WriteLine($"Email {message}");
        }
    }
}
