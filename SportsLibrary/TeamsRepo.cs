using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class TeamsRepo
    {
        public Team teams;
        public SerializableTeam SerializableTeam;

        public Team CurrentTeamItem = new Team("", 0);
        

        public List<Team> ListOfTeams { get; set; }

        public string jsonT;

        public TeamsRepo()
        {
            teams = new Team();
            this.ListOfTeams = new List<Team>();
        }

        public virtual void AddTeam(Team t)
        {
            this.ListOfTeams.Add(t);
        }

        public virtual void AddTeam(string Name, int NumberOfPlayers)
        {
            this.CurrentTeamItem.TeamName = Name;
            this.CurrentTeamItem.NumberOfPlayers = NumberOfPlayers;

            this.ListOfTeams.Add(CurrentTeamItem);
        }

        public virtual void RemoveTeam(string Name, int NumberOfPlayers)
        {
            this.CurrentTeamItem.TeamName = Name;
            this.CurrentTeamItem.NumberOfPlayers = NumberOfPlayers;

            this.ListOfTeams.RemoveAll(u => u.TeamName.StartsWith(Name));

        }

        public virtual void RemoveTeam(Team t)
        {
            this.ListOfTeams.RemoveAll(u => u.TeamName.StartsWith(t.TeamName));

        }

        public void SaveTeam()
        {
            SerializableTeam.TeamsSave(this.teams);
        }

        public void LoadTeam()
        {
            SerializableTeam.TeamLoad(teams.jsonT);
        }
        
    }
}
