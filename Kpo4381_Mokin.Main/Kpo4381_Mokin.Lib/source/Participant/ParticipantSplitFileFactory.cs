using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    internal class ParticipantSplitFileFactory : IParticipantFactory
    {

        public IParticipantListLoader CreateParticipantListLoader()
        {
            return new ParticipantSplitFileLoader();
        }

        public IParticipantListSaver CreateParticipantListSaver()
        {
            return null;
        }
    }
}
