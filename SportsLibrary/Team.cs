using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SportsLibrary
{
    public class Team : ITeam
    {
        public string TeamName { get; set; }
        public int NumberOfPlayers { get; set; }

        public List<Player> TeamOne { get; set; }
        public List<Player> TeamTwo { get; set; }

        public Sport TeamsSport { get; set; }

        public string jsonT;

        public Team() : this("The Bulls", 9) 
        {
            TeamOne = new List<Player>();
            TeamTwo = new List<Player>();
        }

        //public Team() : this("Volleyball", 9, new Sport()) { }

        public Team(string Name, int Number)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
        }

        public Team(string Name, int Number, Sport sport)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
            this.TeamsSport = sport;
        }

        public Team(Sport sport)
        {
            this.TeamsSport = sport;
        }
    }

    public class SerializableTeam: Team
    {
        public string TeamsSave()
        {
            return SaveLoad.JsonSerialize<Team>(this);
        }

        public void TeamLoad(string jsonTeam)
        {
            Team t = SaveLoad.JsonDeserialize<Team>(jsonTeam);
            this.TeamName = t.TeamName;
            this.NumberOfPlayers = t.NumberOfPlayers;
        }
    }

}


