using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLoggerInterface
{
    class FileLogger : ILogger
    {
        public void Log(string data)
        {
            /*
             * https://docs.microsoft.com/en-us/dotnet/api/system.io.file.appendtext?view=netframework-4.8
             */

            data += Environment.NewLine; // equivalent to "\n", but works in all OS environments even Samsung smart TV's

            /*
            // Log data to program folder
            string path = "log.tle";
            File.AppendAllText(path, data);
            */

            //Log data to MyDocuments
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logFolder = "Hut8Logs";
            string logPath = Path.Combine(desktopPath, logFolder);
            
            // Ensure path exists, IE target folder
            Directory.CreateDirectory(logPath);

            // concatenate filename to path
            logPath = Path.Combine(logPath, "log.hut8");
            
            File.AppendAllText(logPath, data);
        }
    }
}