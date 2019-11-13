using System;
using System.Configuration;

namespace Kpo4381_Mokin.Lib
{
    public class AppConfigUtility
    {
        public string AppSettings(string name)
        {

            if (ConfigurationManager.AppSettings[name] != null)
                return ConfigurationManager.AppSettings[name];
            else return String.Empty;

        }
    }
}
