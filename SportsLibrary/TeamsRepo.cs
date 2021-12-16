using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class TeamsRepo
    {
        public Team teams;
        public SerializableTeam SerializableTeam;

        public Team CurrentTeamItem = new Team("", 0, "");
        public Player CurrentPlayer = new Player("", 0);

        public List<Team> ListOfTeams { get; set; }

        public TeamsRepo()
        {
            teams = new Team();
            this.ListOfTeams = new List<Team>();
        }

        public void RemakeTeamsList()
        {
            foreach (Team t in ListOfTeams)
            {
                ListOfTeams.Add(t);
            }
        }

        public void SaveTeam()
        {
            SerializableTeam.TeamsSave();
        }

        public void LoadTeam()
        {
            SerializableTeam.TeamLoad(teams.jsonT);
        }

        public virtual void AddTeam(string Name, int NumberOfPlayers, string WhichSport)
        {
            this.CurrentTeamItem.TeamName = Name;
            this.CurrentTeamItem.NumberOfPlayers = NumberOfPlayers;
            this.CurrentTeamItem.WhichSport = WhichSport;

            this.ListOfTeams.Add(CurrentTeamItem);
        }

        public virtual void RemoveTeam(string Name, int NumberOfPlayers, string WhichSport)
        {
            this.CurrentTeamItem.TeamName = Name;
            this.CurrentTeamItem.NumberOfPlayers = NumberOfPlayers;
            this.CurrentTeamItem.WhichSport = WhichSport;

            if (this.ListOfTeams.Contains(CurrentTeamItem))
            {
                this.ListOfTeams.Remove(CurrentTeamItem);
            }
            return;

        }

        //Sports

        public void RemovePlayerTeamOne(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            if (teams.TeamOne.Contains(CurrentPlayer))
            {
                teams.TeamOne.Remove(CurrentPlayer);
            }
            return;

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
