﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd_Player_Library
{
    class Player
    {
        public string PlayerName { get; set; }
        public string PlayerRace { get; set; }
        public string PlayerClass { get; set; }
        public Stats PlayerStats { get; set; }
        public Inventory PlayerInventory { get; set; }
        public List<Spells> PlayerSpellLibrary { get; set; } = new List<Spells>();


    }
}