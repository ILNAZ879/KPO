using System;
using System.Collections.Generic;
using System.IO;


namespace Kpo4381_Mokin.Lib
{
    //Объявление делегата/процедурного типа
    public delegate void OnLoadFileDelegate(string[] currentRow);

    public class ParticipantSplitFileLoader : IParticipantListLoader
    {
        //Скрытое поле - ссылка на метод делегата
        private OnLoadFileDelegate onAfterRowConvert = null;
        //Метод установки значения делегата
        public void SetAfterRowConvert(OnLoadFileDelegate onAfterRowConvert)
        {
            this.onAfterRowConvert = onAfterRowConvert;
        }
        //Метод чтения значения делегата - только чтение
        public OnLoadFileDelegate AfterRowConvert
        {
            get
            {
                return onAfterRowConvert;
            }
        }

        public ParticipantSplitFileLoader()
        {
            _dataFileName = AppGlobalSettings.dataFileName;
        }

        private readonly string _dataFileName = "";
        private List<Participant> _Transports;
        private LoadStatus _status = LoadStatus.None;
        private string path = AppGlobalSettings.logPath;


        public List<Participant> Participants { get { return _Transports; } }
        public LoadStatus status { get { return _status; } }

        /*Создание метода Execute() для загрузки данных из файла*/
        public List<Participant> Execute()
        {
            //Инициализировать статус выполнения чтения данных
            _status = LoadStatus.ReadingData;

            try
            {
                //Если имя файла не указанно, то вызвать искючение
                if (_dataFileName == string.Empty)
                    throw new Exception("Имя файла не указано!");
                //Если файл не существует, то вызвать искючение
                if (!(File.Exists(path + _dataFileName)))
                    throw new Exception("Файла не существует!");

                //Выполнить загрузку
                //Создание нового списка
                _Transports = new List<Participant>();
                //Чтение данных из файла
                StreamReader sr = null;
                using (sr = new StreamReader(path + _dataFileName))
                {
                    while (!sr.EndOfStream)
                    {
                        //Прочитать очередную строку
                        string str = sr.ReadLine();
                        //Разделить строку на отдельные поля
                        string[] arr = str.Split('|');
                        //Cоздать новый объект
                        Participant transport = new Participant()
                        {
                            //Записать значения полей в свойства объекта
                            surname = arr[0],
                             team_name = arr[1],
                             number_of_balls = arr[2],
                             place_in_the_end = arr[3]
                        };
                        //Добавить объект в список
                        _Transports.Add(transport);

                        //Вызов делегата после каждой прочитанной строки
                        onAfterRowConvert?.Invoke(arr);
                    }
                }
                //Cтатус чтения данных в успешно 
                _status = LoadStatus.Success;
            }
            catch (Exception ex)
            {
                //Статус чтения изменить на ошибочный
                _status = LoadStatus.ReadingError;
                //Запись в журнал ошибок
                LogUtility.ErrorLog(ex);
            }

            return _Transports;
            //для тестирования собственного исключения
            //return null;
        }

    }
}
