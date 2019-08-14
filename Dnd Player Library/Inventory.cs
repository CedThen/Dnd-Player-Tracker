using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd_Player_Library
{
    class Inventory
    {
        public int CopperPieces { get; set; }
        public int SilverPieces { get; set; }
        public int ElectrumPieces { get; set; }
        public int GoldPieces { get; set; }
        public int PlatinumPieces { get; set; }

        public List<Items> ItemList { get; set; } = new List<Items>();
    }
}
