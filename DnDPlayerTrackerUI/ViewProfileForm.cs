using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dnd_Player_Library;

namespace DnDPlayerTrackerUI
{
    public partial class ViewProfileForm : Form
    {
        Player player;
        public ViewProfileForm(Player p)
        {
            InitializeComponent();
            player = p;

            Console.WriteLine(p.PlayerName);
            Console.WriteLine(p.PlayerStats.Level);
            Console.WriteLine(p.PlayerStats.CurrentHP);
            CharacterNameTextBox.Text = p.PlayerName;
            CharacterLevelTextBox.Text = p.PlayerStats.Level.ToString();
            RaceTextBox.Text = p.PlayerRace;
            CharacterExpTextBox.Text = p.PlayerStats.Experience.ToString();
            ClassTextBox.Text = p.PlayerClass;
            SpeedTextBox.Text = p.PlayerStats.Speed.ToString();
            ArmorClassTextBox.Text = p.PlayerStats.ArmorClass.ToString();
            TotalHpTextBox.Text = p.PlayerStats.TotalHP.ToString();
            CurrentHPTextBox.Text = p.PlayerStats.CurrentHP.ToString();
            InitiativeTextBox.Text = p.PlayerStats.Initiative;
            HitDiceTextBox.Text = p.PlayerStats.HitDice;
            ProficiencyTextBox.Text = p.PlayerStats.ProficiencyBonus.ToString();
            StrTextBox.Text = p.PlayerStats.Str.ToString();
            DexTextBox.Text = p.PlayerStats.Dex.ToString();
            ConTextBox.Text = p.PlayerStats.Con.ToString();
            IntTextBox.Text = p.PlayerStats.Int.ToString();
            WisTextBox.Text = p.PlayerStats.Wis.ToString();
            ChaTextBox.Text = p.PlayerStats.Cha.ToString();
        }

        private void ViewProfileForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            Stats s = new Stats(Convert.ToInt32(CharacterLevelTextBox.Text), Convert.ToInt32(TotalHpTextBox.Text),
                Convert.ToInt32(CurrentHPTextBox.Text), Convert.ToInt32(ProficiencyTextBox.Text), HitDiceTextBox.Text,
                Convert.ToInt32(StrTextBox.Text), Convert.ToInt32(DexTextBox.Text), Convert.ToInt32(ConTextBox.Text), Convert.ToInt32(IntTextBox.Text),
                Convert.ToInt32(WisTextBox.Text), Convert.ToInt32(ChaTextBox.Text), InitiativeTextBox.Text, Convert.ToInt32(CharacterExpTextBox.Text),
                Convert.ToInt32(SpeedTextBox.Text), Convert.ToInt32(ArmorClassTextBox.Text));
            Player p = new Player(player.PlayerID, CharacterNameTextBox.Text, RaceTextBox.Text, ClassTextBox.Text, s);

            GlobalConfig.Connection.UpdateProfile(p);
            MessageBox.Show("Profile Updated");
        }
    }
}
