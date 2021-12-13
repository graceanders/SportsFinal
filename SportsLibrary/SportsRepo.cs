using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class SportsRepo : ISportsRepo
    {
        public Player thisplayer = new Player("", 0);
        public Sports thissport = new Sports("", "");

        public string json;

        public SportsRepo()
        {

        }

        public void RemovePlayer(List<Player> ListName) 
        {
            ListName.Remove(this.thisplayer);

        }

        public void AddPlayer(List<Player> ListName)
        {
            ListName.Add(this.thisplayer);
        }

        public void RemoveSport(List<Sports> ListName)
        {
            ListName.Remove(this.thissport);
        }

        public void AddSport(List<Sports> ListName)
        {
            ListName.Add(this.thissport);
        }

        
    }
}
