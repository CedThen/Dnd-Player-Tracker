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
                Convert.ToInt32(SpeedTextBox), Convert.ToInt32(ArmorClassTextBox));
            Player p = new Player(CharacterNameTextBox.Text, RaceTextBox.Text, ClassTextBox.Text, s);

            GlobalConfig.Connection.CreateProfile(p);

            
            ClearTextBoxes();
            MessageBox.Show("Profile has been created");          
        }

        private void ClearTextBoxes()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "a";
                else
                    return;
            }
        }

        private void CharacterCreationForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    ChangeCursor((Button)c);
                }
            }
        }

        private void ChangeCursor(System.Windows.Forms.Button Btn)
        {
            Btn.Cursor = Cursors.Default;
        }

        private void GroupBox_Leave(object sender, EventArgs e)
        {
            TextBox currentTextBox = new TextBox();
            Label currentLabel = DetermineLabel((GroupBox)sender, out currentTextBox);
            int textNum = ValidateInt(currentTextBox.Text);
            if (textNum > 0)
            {                
                currentLabel.Text = MatchMod(textNum);
            }
            else
                return;
            
        }

        private Label DetermineLabel(GroupBox currentBox, out TextBox tb)
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

        private string MatchMod(int num)
        {
            Dictionary<int, string> StatMods = new Dictionary<int, string>()
            {
                { 1, "-5" },
                { 2, "-4"},
                { 3, "-4"},
                { 4, "-3"},
                { 5, "-3"},
                { 6, "-2"},
                { 7, "-2"},
                { 8, "-1"},
                { 9, "-1"},
                { 10, "0"},
                { 11, "0"},
                { 12, "+1"},
                { 13, "+1"},
                { 14, "+2"},
                { 15, "+2"},
                { 16, "+3"},
                { 17, "+3"},
                { 18, "+4"},
                { 19, "+4"},
                { 20, "+5"},
                { 21, "+5"},
                { 22, "+6"},
                { 23, "+6"},
                { 24, "+7"},
                { 25, "+7"},
                { 26, "+8"},
                { 27, "+8"},
                { 28, "+9"},
                { 29, "+9"},
                { 30, "+10"},
            };
            return StatMods[num];
        }

        private int ValidateInt(string text)
        {
            int num = 0;
            if (Int32.TryParse(text, out num))
            {
                if (num > 0 && num < 31)
                    return num;
                else
                {
                    MessageBox.Show("Please enter number between 0 and 30");
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
