using System;
using System.Collections.Generic;
using System.Text;

namespace Dnd_Player_Library
{
    public interface IDataConnection
    {
        Player CreateProfile(Player player);
        List<Player> GetPlayers_All();
        
    }
}
