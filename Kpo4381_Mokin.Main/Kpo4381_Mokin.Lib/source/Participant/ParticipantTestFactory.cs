using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    internal class ParticipantTestFactory : IParticipantFactory
    {
        public IParticipantListLoader CreateParticipantListLoader()
        {
            return new ParticipantListTestLoader();
        }

        public IParticipantListSaver CreateParticipantListSaver()
        {
            return null;
        }
    }
}
