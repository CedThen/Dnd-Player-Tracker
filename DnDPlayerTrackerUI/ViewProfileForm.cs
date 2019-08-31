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
        public ViewProfileForm(Player p)
        {
            InitializeComponent();
            Console.WriteLine(p.PlayerID);
        }
    }
}
