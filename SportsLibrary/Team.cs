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

        public Team() : this(new Sport()) { }

        public Team(string Name, int Number)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
        }

        public Team(Sport sport)
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


