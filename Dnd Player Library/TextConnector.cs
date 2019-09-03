using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dnd_Player_Library.TextHelpers;

namespace Dnd_Player_Library
{
    class TextConnector : IDataConnection
    {
        private const string ProfileFile = "ProfileFile.csv"; //constant, will never change

        public Player CreateProfile(Player player)
        {
            //load the textfile
            //convert text (list of string) to List<Player>
            List<Player> players = ProfileFile.FullFilePath().LoadFile().ConvertToPlayerModel();

            //find the latest/highest ID
            int currentID = 1;
            if(players.Count > 0)
            {
                currentID = players.OrderByDescending(x => x.PlayerID).First().PlayerID + 1;
            }            
            player.PlayerID = currentID;

            //add the new record with the new ID (max+1)
            players.Add(player);

            players.SaveToPlayerFile(ProfileFile);


            //convert the player stuff to list<string>
            //save the list<string> to the text file
            return player;
        }

        public List<Player> GetPlayers_All()
        {
            return ProfileFile.FullFilePath().LoadFile().ConvertToPlayerModel();
            
        }

        public void UpdateProfile(Player player)
        {
            List<Player> players = ProfileFile.FullFilePath().LoadFile().ConvertToPlayerModel();
            Console.WriteLine($"updated profile's id is {player.PlayerID}");
            foreach(Player p in players)
            {
                Console.WriteLine(p.PlayerName, " ", p.PlayerID);
                
                if (p.PlayerID == player.PlayerID)
                {
                    p.PlayerName = player.PlayerName;
                    p.PlayerRace = player.PlayerRace;
                    p.PlayerClass = player.PlayerClass;
                    p.PlayerStats = player.PlayerStats;
                    Console.WriteLine($"Player {p.PlayerName} updated");
                }
            }

            players.SaveToPlayerFile(ProfileFile);
            Console.WriteLine("saved");
        }
    }
}

