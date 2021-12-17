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

        //public Team() : this(new Sport()) { }
        public Team()
        {
            this.TeamOne = new List<Player>();
            this.TeamTwo = new List<Player>();
        }

        public Team(string Name, int Number)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
        }

        public Team(Team t, Sport sport)
        {
            this.TeamsSport = sport;
        }
    }

    public class SerializableTeam: Team
    {
        public void TeamsSave(Team t)
        {
            string jsonT = SaveLoad.JsonSerialize<Team>(t);
        }

        public void TeamLoad(string jsonTeam)
        {
            Team t = SaveLoad.JsonDeserialize<Team>(jsonTeam);
            this.TeamName = t.TeamName;
            this.NumberOfPlayers = t.NumberOfPlayers;
        }
    }

}


