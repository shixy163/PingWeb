using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogHelper
    {
        private ILog log = null;
        public LogHelper()
        {
            log = LogManager.GetLogger("ReflectionLayout");
        }

        public void LogInfo(string msg)
        {
            log.Info(msg);
        }
    }
}
