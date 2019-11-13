using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        private static string _dataFileName;
        private static IParticipantFactory _factory;


        public static string logPath { get { return _logPath; } }
        public static string dataFileName { get { return _dataFileName; } }
        public static IParticipantFactory factory
        {
            get { return _factory; }
        }

        public static void Initialize()
        {
            AppConfigUtility conf = new AppConfigUtility();
            _logPath = conf.AppSettings("logPath");
            _dataFileName = conf.AppSettings("dataFileName");

            if (conf.AppSettings("factory") == "Test")
                _factory = new ParticipantTestFactory();
            if (conf.AppSettings("factory") == "Loader")
                _factory = new ParticipantSplitFileFactory();
        }

    }
}
