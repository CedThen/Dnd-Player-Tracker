using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd_Player_Library.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //takes in file name, which will be DndProfile.csv, and return entire path
        {
            return $@"{ConfigurationManager.AppSettings["filePath"]}\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList(); //returns list of strings of everything in the file
        }

        public static List<Player> ConvertToPlayerModel(this List<string> lines)
        {
            List<Player> output = new List<Player>();

            foreach(string line in lines)
            {
                
                string[] cols = line.Split(',');

                Console.WriteLine(cols.Length);
                Player p = new Player();
                
                p.PlayerID = Convert.ToInt32(cols[0]);
                p.PlayerName = cols[1];
                p.PlayerRace = cols[2];
                p.PlayerClass = cols[3];
                p.PlayerStats.Level = int.Parse(cols[4]);
                p.PlayerStats.TotalHP = Convert.ToInt32(cols[5]);
                p.PlayerStats.CurrentHP = Convert.ToInt32(cols[6]);
                p.PlayerStats.ProficiencyBonus = Convert.ToInt32(cols[7]);
                p.PlayerStats.HitDice = cols[8];
                p.PlayerStats.Str = Convert.ToInt32(cols[9]);
                p.PlayerStats.Dex = Convert.ToInt32(cols[10]);
                p.PlayerStats.Con= Convert.ToInt32(cols[11]);
                p.PlayerStats.Int= Convert.ToInt32(cols[12]);
                p.PlayerStats.Wis= Convert.ToInt32(cols[13]);
                p.PlayerStats.Cha= Convert.ToInt32(cols[14]);
                p.PlayerStats.Initiative = cols[15];
                p.PlayerStats.Experience = Convert.ToInt32(cols[16]);
                p.PlayerStats.Speed = Convert.ToInt32(cols[17]);
                p.PlayerStats.ArmorClass= Convert.ToInt32(cols[18]);

                output.Add(p);
            }

            return output;
        }

        //convert the player stuff to list<string>
        //save the list<string> to the text file
        public static void SaveToPlayerFile(this List<Player> players, string fileName)
        {
            List<string> PlayerModel = new List<string>();            

            foreach(Player p in players)
            {
                PlayerModel.Add($"{p.PlayerID},{p.PlayerName},{p.PlayerRace},{p.PlayerClass},{p.PlayerStats.Level},{p.PlayerStats.TotalHP},{p.PlayerStats.CurrentHP}" +
                    $",{p.PlayerStats.ProficiencyBonus},{p.PlayerStats.HitDice},{p.PlayerStats.Str},{p.PlayerStats.Dex},{p.PlayerStats.Con},{p.PlayerStats.Int}" +
                    $",{p.PlayerStats.Wis},{p.PlayerStats.Cha},{p.PlayerStats.Initiative},{p.PlayerStats.Experience}, {p.PlayerStats.Speed}, {p.PlayerStats.ArmorClass}");
            }
            File.WriteAllLines(fileName.FullFilePath(), PlayerModel);
        }
    }
}
