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
    public partial class PlayerTrackerUIForm : Form
    {
        public PlayerTrackerUIForm()
        {
            InitializeComponent();
            NewCharacterButton.MouseEnter += OnMouseEnterNewCharacterButton;
            NewCharacterButton.MouseLeave += OnMouseLeaveNewCharacterButton;
            
        }

        private void OnMouseEnterNewCharacterButton(object sender, EventArgs e)
        {
            NewCharacterButton.BackColor = Color.Aqua; // or Color.Red or whatever you want
        }
        private void OnMouseLeaveNewCharacterButton(object sender, EventArgs e)
        {
            NewCharacterButton.BackColor = Color.Beige;
        }
    }
}
