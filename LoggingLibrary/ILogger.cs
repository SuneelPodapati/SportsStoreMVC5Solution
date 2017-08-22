using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public interface ILogger
    {
        void LogMessage(string componentName, string action, TimeSpan timeSpan, string message);
    }
}
