using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd_Player_Library
{
    class Stats
    {
        public int StatsID { get; set; }
        public int Level { get; set; }
        public int TotalHP { get; set; }
        public int CurrentHP { get; set; }                
        public int ProficiencyBonus { get; set; }
        public string HitDice { get; set; }

        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        //public int DeathSaveSuccess { get; set; }
        //public int DeathSaveFailure { get; set; }

    }
}
