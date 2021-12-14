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

        public List<Teams> ListOfTeams { get; set; }
        public List<Sports> ListOfSports { get; set; }

        public List<Player> TeamOne { get; set; }
        public List<Player> TeamTwo { get; set; }

        string jsonS, jsonSport, jsonT, jsonTeam;

        public SportsRepo()
        {
            teams = new Teams();
            sports = new Sports();

            this.ListOfTeams = new List<Teams>();
            this.ListOfSports = new List<Sports>();
        }


        Teams CurrentTeamItem = new Teams("", 0, "");
        Sports CurrentSportItem = new Sports("", "");


        //public virtual void AddTeam(Teams t)
        //{
        //    this.ListOfTeams.Add(t);
        //}

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

        //public void RemovePlayer(List<Player> ListName)
        //{
        //    ListName.Remove(this.thisplayer);

        //}

        //public void AddPlayer(List<Player> ListName)
        //{
        //    ListName.Add(this.thisplayer);
        //}

        public void SaveSport()
        {

        }

        public void LoadSport()
        {

        }

    }
}
