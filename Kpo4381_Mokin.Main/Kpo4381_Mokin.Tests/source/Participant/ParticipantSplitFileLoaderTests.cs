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
    public class ParticipantSplitFileLoaderTests
    {

        [TestMethod()]
        //Проверка на возврат не пустого списка
        public void CheckListNotNull_FileLoader()
        {
            AppGlobalSettings.Initialize();
            IParticipantListLoader loader = AppGlobalSettings.factory.CreateParticipantListLoader();
            Assert.IsNotNull(loader.Execute());
        }

        [TestMethod()]
        ////Проверка статуса на успешное чтение при ненулевой сылке на список
        public void CheckListWithStatusSuccess_FileLoader()
        {
            AppGlobalSettings.Initialize();
            IParticipantListLoader loader = AppGlobalSettings.factory.CreateParticipantListLoader();
            //Загрузка из файла
            loader.Execute();

            if (loader.status == LoadStatus.Success && loader.Participants != null)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }
    }
}