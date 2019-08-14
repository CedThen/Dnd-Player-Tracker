using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd_Player_Library
{
    class Stats
    {
        public int Level { get; set; }
        public int CurrentHP { get; set; }
        public int TotalHP { get; set; }
        public int MyProperty { get; set; }
        public int ProficiencyBonus { get; set; }
        public string HitDice { get; set; }
        public int DeathSaveSuccess { get; set; }
        public int DeathSaveFailure { get; set; }

    }
}
