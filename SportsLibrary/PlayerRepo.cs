using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class PlayerRepo : IPlayerRepo
    {
        public Player player;

        public Player CurrentPlayer = new Player("", 0);


        public PlayerRepo()
        {
            player = new Player();

        }


        public List<Player> RemovePlayer(List<Player> list, Player p)
        {
            list.RemoveAll(u => u.Name.StartsWith(p.Name));
            return list;
        }

        public List<Player> RemovePlayer(List<Player> list, string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.PlayerNumber = Number;

            list.RemoveAll(u => u.Name.StartsWith(CurrentPlayer.Name));
            return list;
        }

        public List<Player> AddPlayer(List<Player> list, Player p)
        {
            list.Add(p);
            return list;
        }

        public List<Player> AddPlayer(List<Player> list, string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.PlayerNumber = Number;

            list.Add(CurrentPlayer);
            return list;
        }
    }
}
