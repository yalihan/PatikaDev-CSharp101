using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public class LogManager : ILogger
    {
        public ILogger _iLogger;
        public LogManager(ILogger iLogger)
        {
            _iLogger = iLogger;
        }

        public void WriteLog()
        {
            _iLogger.WriteLog();
        }
    }
}
