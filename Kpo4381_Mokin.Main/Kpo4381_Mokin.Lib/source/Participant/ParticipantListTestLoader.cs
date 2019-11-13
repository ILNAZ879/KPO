using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    public class ParticipantListTestLoader : IParticipantListLoader
    {
        public ParticipantListTestLoader()
        {
        }

        private List<Participant> _participantList = new List<Participant> { };
        private LoadStatus _status = LoadStatus.None;


        public List<Participant> Participants { get { return _participantList; } }
        public LoadStatus status { get { return _status; } }
        public OnLoadFileDelegate AfterRowConvert { get; }

        public List<Participant> Execute()
        {
            _status = LoadStatus.ReadingData;
            try
            {
                {
                    Participant participant = new Participant()
                    {
                         surname = "Баландин",
                         team_name = "Спартак",
                         number_of_balls = "123.7",
                         place_in_the_end = "2"
                    };
                    _participantList.Add(participant);
                }

                {
                    Participant participant = new Participant()
                    {
                        surname = "Шишков",
                        team_name = "Шахтер",
                        number_of_balls = "79.98",
                        place_in_the_end = "3"
                    };
                    _participantList.Add(participant);
                }

                {
                    Participant participant = new Participant()
                    {
                        surname = "Кравченко",
                        team_name = "Динамо",
                        number_of_balls = "134.8",
                        place_in_the_end = "1"
                    };
                    _participantList.Add(participant);
                }
                _status = LoadStatus.Success;
            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                _status = LoadStatus.ReadingError;
                LogUtility.ErrorLog(ex);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                _status = LoadStatus.ReadingError;
                LogUtility.ErrorLog(ex);
            }

            return Participants;
        }

        public void SetAfterRowConvert(OnLoadFileDelegate onAfterRowConvert)
        {
            //throw new NotImplementedException();
        }
    }
}
