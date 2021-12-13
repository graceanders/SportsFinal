using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class Sports: ISports
    {

        public string SportName { get; set; }
        public string SportDescription { get; set; }
        public List <Sports> SportsList { get; set; }

        string json;

        public Sports()
        {
        }


        public Sports (string Name, string Description)
        {
            this.SportName = Name;
            this.SportDescription = Description;
        }

        public void AddSport(Sports s)
        {
            SportsList.Add(s);
        }

        public void SaveSports(Sports s)
        {
            json = JsonConvert.SerializeObject(s);
        }

        public void LoadSports()
        {
            var jsonSports = JsonConvert.DeserializeObject<Sports>(json);

            this.SportName = jsonSports.SportName;
            this.SportDescription = jsonSports.SportDescription;
            this.SportsList = jsonSports.SportsList;

        }
    }
}
