﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class SportsRepo : ISportsRepo
    {
        public Sport sports;
        public SerializableSport SerializableSport;


        //held by the team
        public Player playerone;
        public Player playertwo;

        Sport basketball;
        Sport hockey;

        public List<Team> ListOfTeams { get; set; }
        public List<Sport> ListOfSports { get; set; }

       

        public SportsRepo()
        {
            sports = new Sport();
            SerializableSport = new SerializableSport();

            playerone = new Player();
            playertwo = new Player();

            basketball = new Basketball();
            hockey = new Hockey();

            this.ListOfTeams = new List<Team>();
            this.ListOfSports = new List<Sport>();
            PopulateSports();
        }


        public Team CurrentTeamItem = new Team("", 0, "");
        public Sport CurrentSportItem = new Sport("", "");

        public Player CurrentPlayer = new Player("", 0);

        public void PopulateSports()
        {
            ListOfSports.Add(basketball);
            ListOfSports.Add(hockey);
        }

        public void RemakeSportsList()
        {
            foreach(Sport s in ListOfSports)
            {
                ListOfSports.Add(s);
            }
        }

        public void RemakeTeamsList()
        {
            foreach (Team t in ListOfTeams)
            {
                ListOfTeams.Add(t);
            }
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

            //if (this.TeamOne.Contains(CurrentPlayer))
            //{
            //    this.TeamOne.Remove(CurrentPlayer);
            //}
            //return;

        }

        public void AddPlayerTeamOne(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            //this.TeamOne.Add(CurrentPlayer);
        }

        public void RemovePlayerTeamTwo(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            //if (this.TeamTwo.Contains(CurrentPlayer))
            //{
            //    this.TeamTwo.Remove(CurrentPlayer);
            //}
            //return;

        }

        public void AddPlayerTeamTwo(string Name, int Number)
        {
            this.CurrentPlayer.Name = Name;
            this.CurrentPlayer.Number = Number;

            //this.TeamTwo.Add(CurrentPlayer);
        }

        public void SaveSport()
        {
            SerializableSport.SportSave();
        }

        public void LoadSport()
        {
            SerializableSport.SportLoad(sports.jsonS);
        }

        

    }
}
