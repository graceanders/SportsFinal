using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SportsLibrary
{
    public class Teams : ITeams
    {
        /*
         Teams play (depends on a) a sport. They have names and  players.

         Requirement :  should be able to add and remove players to a team.

         Requirement : app should have a least two teams each with players belonging to the same sport
         */
        public string TeamName { get; set; }
        public int NumberOfPlayers { get; set; }

        public string WhichSport { get; set; }

        //public List<Teams> TeamsList { get; set; }

        //public List<Player> TeamOne { get; set; }
        //public List<Player> TeamTwo { get; set; }


        public Teams() { }

        public Teams(string Name, int Number, string Team)
        {
            this.TeamName = Name;
            this.NumberOfPlayers = Number;
            this.WhichSport = Team;
        }
    }
}
