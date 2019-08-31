using Dnd_Player_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDPlayerTrackerUI
{
    public partial class LoadProfileForm : Form
    {
        private List<Player> availableProfiles = GlobalConfig.Connection.GetPlayers_All();
        private List<Player> selectedPlayers = new List<Player>();
        private Player selectedProfile;

        public LoadProfileForm()
        {
            InitializeComponent();
            foreach(Player p in availableProfiles)
            {
                Console.WriteLine(p.PlayerName);
            }
        }

        private void SelectProfileComboBox_Click(object sender, EventArgs e)
        {
            SelectProfileComboBox.DisplayMember = "PlayerName";
            //SelectProfileComboBox.DisplayMember = "PlayerID";
            SelectProfileComboBox.DataSource = availableProfiles;
            selectedProfile = (Player)SelectProfileComboBox.SelectedItem;
            Console.WriteLine(selectedProfile.PlayerName);
        }

        private void LoadProfileButton_Click(object sender, EventArgs e)
        {
            Form a = new ViewProfileForm(selectedProfile);
            a.Show();
            this.Close();
        }

        private void ReturnMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
