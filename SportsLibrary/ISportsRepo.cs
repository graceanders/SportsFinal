using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface ISportsRepo
    {
        public void RemovePlayer(List<Player> ListName) { }

        public void AddPlayer(List<Player> ListName) { }

        public void RemoveSport(List<Sports> ListName) { }

        public void AddSport(List<Sports> ListName) { }
    }
}
