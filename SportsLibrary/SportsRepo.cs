using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class SportsRepo : ISportsRepo
    {
        Teams teams = new Teams();
        Sports sport = new Sports();

        Sports basketball = new Basketball();

        public SportsRepo()
        {

        }

        //public void RemovePlayer(List<Player> ListName) 
        //{
        //    ListName.Remove(this.thisplayer);

        //}

        //public void AddPlayer(List<Player> ListName)
        //{
        //    ListName.Add(this.thisplayer);
        //}

        //public void RemoveSport(List<Sports> ListName)
        //{
        //    ListName.Remove(this.thissport);
        //}

        //public void AddSport(List<Sports> ListName)
        //{
        //    ListName.Add(this.thissport);
        //}

        
    }
}
