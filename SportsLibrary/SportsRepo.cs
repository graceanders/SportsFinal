using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class SportsRepo : ISportsRepo
    {
        public Teams teams;
        public Sports sports;

        Sports basketball;
        Sports hockey;

        public List<Teams> ListOfTeams { get; set; }
        public List<Sports> ListOfSports { get; set; }

        public List<Player> TeamOne { get; set; }
        public List<Player> TeamTwo { get; set; }

        string jsonS, jsonT;

        public SportsRepo()
        {
            teams = new Teams();
            sports = new Sports();

            basketball = new Basketball();
            hockey = new Hockey();

            this.ListOfTeams = new List<Teams>();
            this.ListOfSports = new List<Sports>();
        }


        public Teams CurrentTeamItem = new Teams("", 0, "");
        public Sports CurrentSportItem = new Sports("", "");
        
        public void PopulateSports()
        {
            ListOfSports.Add(basketball);
            ListOfSports.Add(hockey);
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

        public virtual void AddSport(string Name, string Description)
        {
            this.CurrentSportItem.SportName = Name;
            this.CurrentSportItem.SportDescription = Description;

            this.ListOfSports.Add(CurrentSportItem);
        }

        public virtual void RemoveSport(string Name, string Description)
        {
            this.CurrentSportItem.SportName = Name;
            this.CurrentSportItem.SportDescription = Description;

            if (this.ListOfSports.Contains(CurrentSportItem))
            {
                this.ListOfSports.Remove(CurrentSportItem);
            }
            return;
        }

        public void RemovePlayerTeamOne(Player p)
        {
            TeamOne.Remove(p);

        }

        public void AddPlayerTeamOne(Player p)
        {
            TeamTwo.Add(p);
        }

        public void RemovePlayerTeamTwo(Player p)
        {
            TeamOne.Remove(p);

        }

        public void AddPlayerTeamTwo(Player p)
        {
            TeamTwo.Add(p);
        }

        public void SaveSport()
        {
            jsonS = JsonConvert.SerializeObject(sports);
        }

        public void LoadSport()
        {
            var jsonSport = JsonConvert.DeserializeObject<Sports>(jsonS);
            sports = jsonSport;
        }

        public void SaveTeam()
        {
            jsonT = JsonConvert.SerializeObject(teams);
        }

        public void LoadTeam()
        {
            var jsonTeams = JsonConvert.DeserializeObject<Teams>(jsonT);
            teams = jsonTeams;
        }

    }
}
