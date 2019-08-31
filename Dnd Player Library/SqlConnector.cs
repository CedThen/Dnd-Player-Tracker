using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Linq;

namespace Dnd_Player_Library
{
    public class SqlConnector : IDataConnection
    {
        public Player CreateProfile(Player player)
        {
            using (IDbConnection Connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("DnDPlayerTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@PlayerName", player.PlayerName);
                p.Add("@PlayerRace", player.PlayerRace);
                p.Add("@PlayerClass", player.PlayerClass);
                p.Add("@PlayerLevel", player.PlayerStats.Level);
                p.Add("@PlayerTotalHP", player.PlayerStats.TotalHP);
                p.Add("@PlayerCurrentHP", player.PlayerStats.CurrentHP);
                p.Add("@PlayerProficiencyBonus", player.PlayerStats.ProficiencyBonus);
                p.Add("@PlayerHitDice", player.PlayerStats.HitDice);
                p.Add("@PlayerStr", player.PlayerStats.Str);
                p.Add("@PlayerDex", player.PlayerStats.Dex);
                p.Add("@PlayerCon", player.PlayerStats.Con);
                p.Add("@PlayerInt", player.PlayerStats.Int);
                p.Add("@PlayerWis", player.PlayerStats.Wis);
                p.Add("@PlayerCha", player.PlayerStats.Cha);
                p.Add("@PlayerInitiative", player.PlayerStats.Initiative);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                Connection.Execute("dbo.InsertIntoPlayers", p, commandType: CommandType.StoredProcedure);

                player.PlayerID = p.Get<int>("@id");

                return player;

            }//connection is closed at this point, and will prevent memory leaks
        }

        public List<Player> GetPlayers_All()
        {
            List<Player> output;
            using (IDbConnection Connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("DnDPlayerTracker")))
            {
                output = Connection.Query<Player>("dbo.GetPlayer").ToList();
            }
            return output;
        }
    }

    
}
