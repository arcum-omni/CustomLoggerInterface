using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLoggerInterface
{
    /// <summary>
    /// Logs info to the console
    /// </summary>
    class ConsoleLogger : ILogger
    {
        public void Log(string info)
        {
            Console.WriteLine(info);
        }
    }
}