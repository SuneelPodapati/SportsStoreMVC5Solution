using System;
using System.Diagnostics;

namespace LoggingLibrary
{
    public class Logger : ILogger
    {
        public void LogMessage(string componentName, string action, TimeSpan timeSpan, string message)
        {
            string str = string.Format("---------------------------------------------\n\tComponentName: {0}, Action: {1}, TimeSpan: {2} and Message: {3}\n---------------------------------------------", componentName, action, timeSpan, message);
            Debug.WriteLine(str);
            //Trace.WriteLine(str);
        }
    }
}
