using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface IPlayerRepo
    {
        List<Player> RemovePlayer(List<Player> list, Player p);
        List<Player> RemovePlayer(List<Player> list, string Name, int Number);
        List<Player> AddPlayer(List<Player> list, Player p);
        List<Player> AddPlayer(List<Player> list, string Name, int Number);
    }
}
