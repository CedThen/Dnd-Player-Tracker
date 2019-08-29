using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace Dnd_Player_Library
{
    class SqlConnector : IDataConnection
    {
        public Player CreateProfile(Player player)
        {
            using(IDbConnection Connection new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("DnDPlayerTracker")) 
                {

            }
        }


    }
}
