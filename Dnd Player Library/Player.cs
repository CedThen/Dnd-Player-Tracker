using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd_Player_Library
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerRace { get; set; }
        public string PlayerClass { get; set; }
        public Stats PlayerStats { get; set; }
        //public List<Equipment> PlayerEquipment { get; set; }
        //public Purse PlayerPurse { get; set; }
        //public List<Spells> PlayerSpellLibrary { get; set; } = new List<Spells>();

        public Player(string pName, string pRace, string pClass, Stats pStats)
        {
            PlayerName = pName;
            PlayerRace = pRace;
            PlayerClass = pClass;
            PlayerStats = pStats;
            
        }

        public Player()
        {
            Stats s = new Stats();
            PlayerStats = s;
        }

        public Player(int playerID, string playerName, string playerRace, string playerClass, int level, int totalHP, int currentHP,
            int proficiencyBonus, string hitDice, int str, int dex,
            int con, int @int, int wis, int cha, string initative)
        {
            Stats s = new Stats(level, totalHP, currentHP, proficiencyBonus, hitDice, str, dex, con, @int, wis, cha, initative);
            PlayerID = playerID;
            PlayerName = playerName;
            PlayerRace = playerRace;
            PlayerClass = playerClass;
            PlayerStats = s;
        }
    }
}
