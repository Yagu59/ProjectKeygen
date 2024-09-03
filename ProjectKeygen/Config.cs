using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKeygen
{
    public struct Configen
    {
        public string softwareName;
        public string teamName;
        public string labelContext;
        public string aboutContext;
        public string generateButtonContext;

        public AudioSettings audioSettings;

        public Log log;
    }

    public struct Log
    {
        public string LOAD_NUMBER;
    }

    public struct AudioSettings
    {
        public float volume;
        public int deviceNumber;
    }
}
