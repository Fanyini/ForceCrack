using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceCrack
{
    public class Logger
    {
        private Logger() { }

        private static Logger _instance = null;
        public static Logger instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Logger();

                return _instance;
            }
        }

        public void Log(string content)
        {

        }
    }
}
