using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_Mokin.Lib 
{
    public class Participant
    {
        public Participant()
        {

            surname = "";
            team_name = "";
            number_of_balls = "";
            place_in_the_end = "";
        }
        public string surname { get; set; }
        public string team_name { get; set; }
        public string number_of_balls { get; set; }
        public string place_in_the_end { get; set; }

    }
}
