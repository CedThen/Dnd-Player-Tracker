using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDPlayerTrackerUI
{
    class FormHelperMethods
    {
        public static void UpdateGroupBoxText(Label label, string text)
        {
            label.Text = text;
        }
    }
}
