using System;
using System.Windows.Forms;
using Kpo4381_Mokin.Lib;

namespace Kpo4381_Mokin.Main
{
    public partial class FrmMain : Form
    {
        private BindingSource bsTransports = new BindingSource();


        public FrmMain()
        {
            InitializeComponent();
        }


        private void mnOpen_Click(object sender, EventArgs e)
        {
            //Для моделирования ситуации, когда имя файла протокола не задано нужно закомментировать
           LogUtility.FileNameProtocol = "error.log"; //задаем имя файла протокола

            try
            {
                //Раскомментировать для моделирования ситуации, когда имя файла протокола не задано 
               // throw new MyException("Создания исключения для проверки утверждения в классе записи протокола");

                //обращение к созданным объектам через интерфейс
                IParticipantListLoader loader = AppGlobalSettings.factory.CreateParticipantListLoader();

                //Задать метод, выполняемый после обработки каждой строки
                loader.SetAfterRowConvert(OnAfterRowConvert);

                //Для демонстрации защитного программирования с постусловаием
                // loader.SetAfterRowConvert(null);
                // System.Diagnostics.Debug.Assert(loader.AfterRowConvert == OnAfterRowConvert, "Сылка на метод не соответствует методу, который предназначен для перечачи в качестве делегата"); //Утверждение c постусловием

                //Загрузка из файла
                if (loader.Execute() == null)
                    throw new MyException("Отсутствует ссылка на список");

                bsTransports.DataSource = loader.Participants;
                dgvTransports.DataSource = bsTransports;


            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            //обработка остальных исключений
            catch (MyException ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }

        private void mnOpenParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                //Создать экземпляр формы
                FrmParticipant frm_participant = new FrmParticipant();

                //Задать сылка на текущий объект в таблицы
                Participant participant = (bsTransports.Current as Participant);
                frm_participant.SetParticipant(participant);

                //открыть форму в модальном режиме
                frm_participant.ShowDialog();

            }
            catch (NotImplementedException ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }

        //Метод для передачи в качетсве делегата
        public void OnAfterRowConvert(string[] currentRow)
        {

            ActiveForm.Text = "Чтение файла завершена!!!";
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
