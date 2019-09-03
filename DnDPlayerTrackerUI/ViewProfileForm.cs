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
            FillTextBoxes(p);
            SetStatMods();

        }

        private void FillTextBoxes(Player p)
        {
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

        private void SetStatMods()
        {
            StrModLabel.Text = Dictionaries.StatDictionary(player.PlayerStats.Str).ToString();
            DexModLabel.Text = Dictionaries.StatDictionary(player.PlayerStats.Dex).ToString();
            ConModLabel.Text = Dictionaries.StatDictionary(player.PlayerStats.Con).ToString();
            IntModLabel.Text = Dictionaries.StatDictionary(player.PlayerStats.Int).ToString();
            WisModLabel.Text = Dictionaries.StatDictionary(player.PlayerStats.Wis).ToString();
            ChaModLabel.Text = Dictionaries.StatDictionary(player.PlayerStats.Cha).ToString();
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

        private void ResetSlotsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("resetting");
            foreach (GroupBox ctrl in this.Controls.OfType<GroupBox>()) //We get all of groupboxes that is in our form (We want the checkboxes which are only in a groupbox.Not all of the checkboxes in the form.)
            {
                foreach (Panel p in ctrl.Controls.OfType<Panel>()) //We get all of checkboxes which are in panel 
                {
                    foreach(CheckBox c in p.Controls.OfType<CheckBox>())
                    {
                        c.Checked = false;
                    }
                }
            }            
        }

        public void GroupBox_Leave(object sender, EventArgs e)
        {
            TextBox currentTextBox;
            Label currentLabel = DetermineLabel((GroupBox)sender, out currentTextBox);
            int textNum = ValidateInt(currentTextBox.Text);
            if (textNum > 0)
            {
                currentLabel.Text = Dictionaries.StatDictionary(textNum);
            }
        }

        public Label DetermineLabel(GroupBox currentBox, out TextBox tb)
        {
            switch (currentBox.Text)
            {
                case "Strength":
                    tb = StrTextBox;
                    return StrModLabel;
                case "Dexterity":
                    tb = DexTextBox;
                    return DexModLabel;
                case "Constitution":
                    tb = ConTextBox;
                    return ConModLabel;
                case "Intelligence":
                    tb = IntTextBox;
                    return IntModLabel;
                case "Wisdom":
                    tb = WisTextBox;
                    return WisModLabel;
                case "Charisma":
                    tb = ChaTextBox;
                    return ChaModLabel;
                default:
                    break;
            }
            tb = null;
            return null;
        }

        public int ValidateInt(string text)
        {
            int num;
            if (Int32.TryParse(text, out num))
            {
                if (num > 0 && num < 31)
                    return num;
                else
                {
                    MessageBox.Show("Please enter a number between 1 and 30");
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Invalid information");
                return -1;
            }
        }
    }
}
