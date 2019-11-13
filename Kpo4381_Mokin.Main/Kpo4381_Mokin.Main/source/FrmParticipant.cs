using System.Windows.Forms;
using Kpo4381_Mokin.Lib;

namespace Kpo4381_Mokin.Main
{
    public partial class FrmParticipant : Form
    {
        public FrmParticipant()
        {
            InitializeComponent();
            _participant = null;

        }

        private Participant _participant = null;
        public Participant participant
        {
            get { return _participant; }
        }

        public void SetParticipant(Participant participant)
        {
            tb_team_name.Text = participant.team_name.ToString();
            tb_number_of_balls.Text = participant.number_of_balls.ToString();
            tb_place.Text = participant.place_in_the_end.ToString();

        }

    }
}
