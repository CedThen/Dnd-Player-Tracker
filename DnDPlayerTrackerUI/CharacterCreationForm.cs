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
        bool bName, bInitiative, bStr, bDex, bCon, bInt, bWis, bCha;
        


        public CharacterCreationForm()
        {
            InitializeComponent();
            bName = bInitiative = bStr = bDex = bCon = bInt = bWis = bCha = false;
        }

        private void TextBox_LeaveFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
                ((TextBox)sender).BackColor = Color.AliceBlue;
            else
                return;
        }
        private void TextBox_MouseClick(object sender, EventArgs e)
        {            
            if (!n)
            {
                ((TextBox)sender).Text = "";
                n = true;
            }
            else
                return;            
        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            Stats s = new Stats(Convert.ToInt32(CharacterLevelTextBox.Text), Convert.ToInt32(TotalHpTextBox.Text),
                Convert.ToInt32(CurrentHPTextBox.Text), Convert.ToInt32(ProficiencyTextBox.Text), HitDiceTextBox.Text,
                Convert.ToInt32(StrTextBox.Text), Convert.ToInt32(DexTextBox.Text), Convert.ToInt32(ConTextBox.Text), Convert.ToInt32(IntTextBox.Text),
                Convert.ToInt32(WisTextBox.Text), Convert.ToInt32(CharTexBox.Text), InitiativeTextBox.Text);
            Player p = new Player(CharacterNameTextBox.Text, RaceTextBox.Text, ClassTextBox.Text, s);

            GlobalConfig.Connection.CreateProfile(p);


            //Dnd_Player_Library.SqlConnector.CreateProfile(p, s);
            //SqlDataAdapter sqlDataAdaper
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
            Btn.Cursor = Cursors.Hand;
        }

        private void GroupBox_Leave(object sender, EventArgs e)
        {
            int textNum = ValidateInt(StrTextBox.Text);
            if (textNum > 0)
            {
                StrModLabel.Text = MatchMod(textNum);
            }
            else
                return;
            
            
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
                return num;
            }
            else
            {
                MessageBox.Show("Invalid information");
                return -1;
            }
        }
    }
}
