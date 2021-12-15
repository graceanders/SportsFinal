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
        public Player playerone;
        public Player playertwo;

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
            playerone = new Player();
            playertwo = new Player();

            basketball = new Basketball();
            hockey = new Hockey();

            this.ListOfTeams = new List<Teams>();
            this.ListOfSports = new List<Sports>();
            PopulateSports();
        }


        public Teams CurrentTeamItem = new Teams("", 0, "");
        public Sports CurrentSportItem = new Sports("", "");

        public Player CurrentPlayer = new Player("", 0);
        
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

        public void RemovePlayerTeamOne(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            if (this.TeamOne.Contains(CurrentPlayer))
            {
                this.TeamOne.Remove(CurrentPlayer);
            }
            return;

        }

        public void AddPlayerTeamOne(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            this.TeamOne.Add(CurrentPlayer);
        }

        public void RemovePlayerTeamTwo(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            if (this.TeamTwo.Contains(CurrentPlayer))
            {
                this.TeamTwo.Remove(CurrentPlayer);
            }
            return;

        }

        public void AddPlayerTeamTwo(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            this.TeamTwo.Add(CurrentPlayer);
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
