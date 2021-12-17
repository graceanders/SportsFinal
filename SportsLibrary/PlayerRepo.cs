using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class PlayerRepo : IPlayerRepo
    {
        public Player CurrentPlayer = new Player("", 0);

        public PlayerRepo() { }


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

        //public void RemovePlayerTeamOne(Player p)
        //{
        //    teams.TeamOne.RemoveAll(u => u.Name.StartsWith(p.Name));

        //}

        //public void RemovePlayerTeamOne(string Name, int Number)
        //{
        //    this.CurrentPlayer.Name = Name;
        //    this.CurrentPlayer.Number = Number;

        //    teams.TeamOne.RemoveAll(u => u.Name.StartsWith(CurrentPlayer.Name));
        //}

        //public void AddPlayerTeamOne(string Name, int Number)
        //{
        //    this.CurrentPlayer.Name = Name;
        //    this.CurrentPlayer.Number = Number;

        //    teams.TeamOne.Add(CurrentPlayer);
        //}

        //public void RemovePlayerTeamTwo(string Name, int Number)
        //{
        //    this.CurrentPlayer.Name = Name;
        //    this.CurrentPlayer.Number = Number;

        //    if (teams.TeamTwo.Contains(CurrentPlayer))
        //    {
        //        teams.TeamTwo.Remove(CurrentPlayer);
        //    }
        //    return;

        //}

        //public void AddPlayerTeamTwo(string Name, int Number)
        //{
        //    this.CurrentPlayer.Name = Name;
        //    this.CurrentPlayer.Number = Number;

        //    teams.TeamTwo.Add(CurrentPlayer);
        //}
    }
}
