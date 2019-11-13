using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    public interface IParticipantListLoader
    {
        List<Participant> Execute();

        List<Participant> Participants { get; }
        LoadStatus status { get; }

        void SetAfterRowConvert(OnLoadFileDelegate onAfterRowConvert);
        OnLoadFileDelegate AfterRowConvert { get; }
    }
}

public enum LoadStatus
{
    None = -1,
    ReadingData = 0,
    Success = 1,
    ReadingError = 2
}