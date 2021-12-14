using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class SportsRepo : ISportsRepo
    {
        ITeams teams;
        ISports sports;

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


        Teams CurrentTeamItem = new Teams("", 0, "");
        Sports CurrentSportItem = new Sports("", "");
        
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
        }

        public virtual Teams RemoveTeam(Teams t)
        {
            if (this.ListOfTeams.Remove(t))
            {
                return t;
            }
            return null;
        }

        public virtual void AddSport(string Name, string Description)
        {
            this.CurrentSportItem.SportName = Name;
            this.CurrentSportItem.SportDescription = Description;

            this.ListOfSports.Add(CurrentSportItem);
        }

        public virtual Sports RemoveSport(Sports s)
        {
            if (this.ListOfSports.Remove(s))
            {
                return s;
            }
            return null;
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
