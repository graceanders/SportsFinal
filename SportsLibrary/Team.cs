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

        public List<Player> TeamOne { get; set; }
        public List<Player> TeamTwo { get; set; }

        public Player playerone;
        public Player playertwo;

        public Team() { }

        public string jsonT; 

        public Team(string Name, int Number, string Team)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
            this.WhichSport = Team;

            playerone = new Player();
            playertwo = new Player();
        }
    }

    public class SerializableTeam: Team
    {
        public void TeamsSave()
        {
            string jsonT = SaveLoad.JsonSerialize<Team>(this);
        }

        public void TeamLoad(string jsonTeam)
        {
            Team t = SaveLoad.JsonDeserialize<Team>(jsonTeam);
            this.TeamName = t.TeamName;
            this.NumberOfPlayers = t.NumberOfPlayers;
        }
    }

}


