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
        bool n = false;        


        public CharacterCreationForm()
        {
            InitializeComponent();            
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
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
                Convert.ToInt32(WisTextBox.Text), Convert.ToInt32(CharTexBox.Text));
            Player p = new Player(CharacterNameTextBox.Text, RaceTextBox.Text, ClassTextBox.Text, s);





            //Dnd_Player_Library.SqlConnector.CreateProfile(p, s);
            //SqlDataAdapter sqlDataAdaper

            MessageBox.Show("Profile has been created");

            ClearTextBoxes();

        }

        private void ClearTextBoxes()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
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

    }
}
