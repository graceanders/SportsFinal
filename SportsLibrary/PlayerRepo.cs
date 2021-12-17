using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class PlayerRepo
    {
        public Team teams;

        public Player CurrentPlayer = new Player("", 0);

        public PlayerRepo()
        {
            teams = new Team();
        }

        public void RemovePlayerTeamOne(Player p)
        {
            teams.TeamOne.RemoveAll(u => u.Name.StartsWith(p.Name));

        }

        public void RemovePlayerTeamOne(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            teams.TeamOne.RemoveAll(u => u.Name.StartsWith(CurrentPlayer.Name));
        }

        public void AddPlayerTeamOne(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            teams.TeamOne.Add(CurrentPlayer);
        }

        public void RemovePlayerTeamTwo(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            if (teams.TeamTwo.Contains(CurrentPlayer))
            {
                teams.TeamTwo.Remove(CurrentPlayer);
            }
            return;

        }

        public void AddPlayerTeamTwo(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            teams.TeamTwo.Add(CurrentPlayer);
        }
    }
}
