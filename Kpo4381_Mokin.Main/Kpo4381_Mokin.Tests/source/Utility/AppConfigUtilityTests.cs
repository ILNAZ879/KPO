using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4381_Mokin.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib.Tests
{
    [TestClass()]
    public class AppConfigUtilityTests
    {
        [TestMethod()]
        //Метод должен возвращать пустую строку, если в качество входного парамметра принята пустая строка
        public void AppSettingsTest()
        {
            AppConfigUtility con = new AppConfigUtility();
            string temp = con.AppSettings("");
            if (temp == String.Empty)
                Assert.IsTrue(true);
            else Assert.IsTrue(false);
        }
    }
}