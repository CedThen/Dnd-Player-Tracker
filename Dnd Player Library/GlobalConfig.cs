using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace Dnd_Player_Library
{
    public static class GlobalConfig
    {

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            //Initialize connections here


            if (db == DatabaseType.Sql)
            {
                //TODO - set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                //TODO - Create the text connection 
                TextConnector txt = new TextConnector();
                Connection = txt;
            }
        }

        public static string CnnString(string name) //goes to app.config and gets connection string, by looking up a name, and returns the value of the string inside the name
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }




    }
}
