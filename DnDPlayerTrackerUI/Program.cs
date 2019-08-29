using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DnDPlayerTrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Dnd_Player_Library.GlobalConfig.InitializeConnections(Dnd_Player_Library.DatabaseType.Sql);

            Application.Run(new PlayerTrackerUIForm());
            
        }
    }
}
