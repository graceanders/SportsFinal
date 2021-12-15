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


        public Team() { }

        public Team(string Name, int Number, string Team)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
            this.WhichSport = Team;
        }
    }
}
