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

        public string WhichSport { get; set; }


        //player that belongs to a tema
        //list of players

        public Team() { }

        public Team(string Name, int Number, string Team)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
            this.WhichSport = Team;
        }

        


    }

    public class SerializableTeam: Team
    {
        public void TeamsSave()
        {
            string json = SaveLoad.JsonSerialize<Team>(this);
        }

        public void TeamLoad(string jsonTeam)
        {
            Team t = SaveLoad.JsonDeserialize<Team>(jsonTeam);
            this.TeamName = t.TeamName;
        }
    }

}


