using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface ISportsRepo
    {
        public void RemovePlayer(List<Player> ListName) { }

        public void AddPlayer(List<Player> ListName) { }

        public void RemoveSport(List<Sport> ListName) { }

        public void AddSport(List<Sport> ListName) { }
    }
}
