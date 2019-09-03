using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dnd_Player_Library;


namespace DnDPlayerTrackerUI
{
    
    public partial class CharacterCreationForm : Form
    {
        bool bName, bInitiative, bStr, bDex, bCon, bInt, bWis, bCha, bProf;
        


        public CharacterCreationForm()
        {
            InitializeComponent();
            bName = bProf = bInitiative = bStr = bDex = bCon = bInt = bWis = bCha = false;
        }

        private void TextBox_LeaveFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
            {
                ((TextBox)sender).BackColor = Color.AliceBlue;                
                this.ActiveControl = null;
            }

                
            else
                return;
        }


        private void CharacterNameTextBox_MouseClick(object sender, EventArgs e)
        {
            //if (!bName)
            //{
            //    ((TextBox)sender).Text = "";
            //    bName = true;
            //}
            //
        }

        private void ProficiencyTextBox_MouseClick(object sender, EventArgs e)
        {
            if(!bProf)
            {
                ((TextBox)sender).Text = "";
                bProf = true;
            }
            else
                return;
        }

        private void StrTextBox_MouseClick(object sender, EventArgs e)
        {
            if (!bStr)
            {
                ((TextBox)sender).Text = "";
                bStr = true;
            }
            else
                return;
        }

        private void DexTextBox_MouseClick(object sender, EventArgs e)
        {
            if (!bDex)
            {
                ((TextBox)sender).Text = "";
                bDex = true;
            }
            else
                return;
        }

        private void InitiativeTextBox_MouseClick(object sender, EventArgs e)
        {
            if (!bInitiative)
            {
                ((TextBox)sender).Text = "";
                bInitiative = true;
            }
            else
                return;
        }

        private void TextBox_MouseClick(object sender, EventArgs e)
        {            
            //if (!n)
            //{
            //    ((TextBox)sender).Text = "";
            //    n = true;
            //}
            //else
            //    return;            
        }

        private void ConTextBox_MouseClick(object sender, EventArgs e)
        {
            if (!bCon)
            {
                ((TextBox)sender).Text = "";
                bCon = true;
            }
            else
                return;
        }

        private void IntTextBox_MouseClick(object sender, EventArgs e)
        {
            if (!bInt)
            {
                ((TextBox)sender).Text = "";
                bInt = true;
            }
            else
                return;
        }

        private void WisTextBox_MouseClick(object sender, EventArgs e)
        {
            if (!bWis)
            {
                ((TextBox)sender).Text = "";
                bWis = true;
            }
            else
                return;
        }

        private void ChaTextBox_MouseClick(object sender, EventArgs e)
        {
            if (!bCha)
            {
                ((TextBox)sender).Text = "";
                bCha = true;
            }
            else
                return;
        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            Stats s = new Stats(Convert.ToInt32(CharacterLevelTextBox.Text), Convert.ToInt32(TotalHpTextBox.Text),
                Convert.ToInt32(CurrentHPTextBox.Text), Convert.ToInt32(ProficiencyTextBox.Text), HitDiceTextBox.Text,
                Convert.ToInt32(StrTextBox.Text), Convert.ToInt32(DexTextBox.Text), Convert.ToInt32(ConTextBox.Text), Convert.ToInt32(IntTextBox.Text),
                Convert.ToInt32(WisTextBox.Text), Convert.ToInt32(ChaTextBox.Text), InitiativeTextBox.Text, Convert.ToInt32(CharacterExpTextBox.Text),
                Convert.ToInt32(SpeedTextBox.Text), Convert.ToInt32(ArmorClassTextBox.Text));
            Player p = new Player(CharacterNameTextBox.Text, RaceTextBox.Text, ClassTextBox.Text, s);

            GlobalConfig.Connection.CreateProfile(p);

            MessageBox.Show("Profile has been created");          
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
            switch(currentBox.Text)
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
            int num = 0;
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
