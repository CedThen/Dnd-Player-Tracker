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
                p.Add("@PlayerExperience", player.PlayerStats.Experience);
                p.Add("@PlayerSpeed", player.PlayerStats.Speed);
                p.Add("@PlayerAC", player.PlayerStats.ArmorClass);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                Connection.Execute("dbo.InsertIntoPlayers", p, commandType: CommandType.StoredProcedure);

                player.PlayerID = p.Get<int>("@id");

                return player;

            }//connection is closed at this point, and will prevent memory leaks
        }

        public List<Player> GetPlayers_All()
        {
            List<Player> output;
            //Player p;
            
            using (IDbConnection Connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("DnDPlayerTracker")))
            {
                //statOutput = (Stats)Connection.Query<Stats>("dbo.GetPlayerStats");
                output = Connection.Query<Player>("dbo.GetPlayer").ToList();
                
            }
            //output.PlayerStats = statOutput;
            return output;
            
        }

        public void UpdateProfile(Player player)
        {
            using (IDbConnection Connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("DnDPlayerTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@PlayerName", player.PlayerName);
                p.Add("@PlayerRace", player.PlayerRace);
                p.Add("@PlayerClass", player.PlayerClass);
                var q = new DynamicParameters();
                q.Add("@PlayerLevel", player.PlayerStats.Level);
                q.Add("@PlayerTotalHP", player.PlayerStats.TotalHP);
                q.Add("@PlayerCurrentHP", player.PlayerStats.CurrentHP);
                q.Add("@PlayerProficiencyBonus", player.PlayerStats.ProficiencyBonus);
                q.Add("@PlayerHitDice", player.PlayerStats.HitDice);
                q.Add("@PlayerStr", player.PlayerStats.Str);
                q.Add("@PlayerDex", player.PlayerStats.Dex);
                q.Add("@PlayerCon", player.PlayerStats.Con);
                q.Add("@PlayerInt", player.PlayerStats.Int);
                q.Add("@PlayerWis", player.PlayerStats.Wis);
                q.Add("@PlayerCha", player.PlayerStats.Cha);
                q.Add("@PlayerInitiative", player.PlayerStats.Initiative);
                q.Add("@PlayerExperience", player.PlayerStats.Experience);
                q.Add("@PlayerSpeed", player.PlayerStats.Speed);
                q.Add("@PlayerAC", player.PlayerStats.ArmorClass);

                Connection.Execute("dbo.UpdatePlayer", p, commandType: CommandType.StoredProcedure);
                Connection.Execute("dbo.UpdateStats", p, commandType: CommandType.StoredProcedure);
            }
        }
    }

    
}
