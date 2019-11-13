using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    public static class LogUtility
    {
        private static string _FileNameProtocol;
        public static string FileNameProtocol
        {
            set { _FileNameProtocol = value; }
        }

        public static void ErrorLog(string message)
        {
            System.Diagnostics.Debug.Assert(_FileNameProtocol != null, "Имя файла не задано!"); //Утверждение
            File.AppendAllText(_FileNameProtocol, DateTime.Now + " - " + message + " \r\n");
        }

        public static void ErrorLog(Exception ex)
        {
            System.Diagnostics.Debug.Assert(_FileNameProtocol != null, "Имя файла не задано!"); //Утверждение
            File.AppendAllText(_FileNameProtocol, DateTime.Now + " - " + ex.Message + " \r\n");
        }
    }
}
