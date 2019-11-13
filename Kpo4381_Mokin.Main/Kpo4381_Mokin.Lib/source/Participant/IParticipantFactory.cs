using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    public interface IParticipantFactory
    {

        IParticipantListLoader CreateParticipantListLoader();
        IParticipantListSaver CreateParticipantListSaver();

    }
}
