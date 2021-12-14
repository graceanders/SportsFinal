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

        Teams CurrentTeamItem = new Teams("", 0,"");
        Sports CurrentSportItem = new Sports("", "");

        public SportsRepo()
        {

        }

        public void AddToList(string ListName)
        {
            //Sport has Name string and Description string
            //Team has Name string NumberOfPlayers int and WhichSport string

            if(ListName == "SportsList")
            {
                
                sport.SportsList.Add(CurrentSportItem);
            }
            else if (ListName == "TeamsList")
            {
                teams.TeamsList.Add(CurrentTeamItem);
            }

            
            
        }

        public void RemoveFromList()
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
            ListName.Remove(this.CurrentSportItem);
        }

        public void AddSport(List<Sports> ListName)
        {
            ListName.Add(this.CurrentSportItem);
        }


    }
}
