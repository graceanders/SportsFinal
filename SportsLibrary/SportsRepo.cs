using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsLibrary
{
    public class SportsRepo : ISportsRepo
    {
        public Sport sports;
        public SerializableSport SerializableSport;
        

        Sport basketball;
        Sport hockey;

        public List<Sport> ListOfSports { get; set; }

        public Sport CurrentSportItem = new Sport("", "");

        public SportsRepo()
        {
            sports = new Sport();
            SerializableSport = new SerializableSport();

            basketball = new Basketball();
            hockey = new Hockey();

            
            this.ListOfSports = new List<Sport>();
            PopulateSports();
        }
        
        public void PopulateSports()
        {
            ListOfSports.Add(basketball);
            ListOfSports.Add(hockey);
        }

        public void RemakeSportsList()
        {
            foreach(Sport s in ListOfSports)
            {
                ListOfSports.Add(s);
            }
        }
        

        public virtual void AddSport(string Name, string Description)
        {
            this.CurrentSportItem.SportName = Name;
            this.CurrentSportItem.SportDescription = Description;

            this.ListOfSports.Add(CurrentSportItem);
        }

        //issues

        public virtual void RemoveSport(string Name, string Description)
        {
            this.CurrentSportItem.SportName = Name;
            this.CurrentSportItem.SportDescription = Description;

            ListOfSports.RemoveAll(u => u.SportName.StartsWith(Name));

        }

        public virtual void RemoveSport(Sport s)
        {
            ListOfSports.RemoveAll(u => u.SportName.StartsWith(s.SportName));

        }

        public void SaveSport()
        {
            SerializableSport.SportSave();
        }

        public void LoadSport()
        {
            SerializableSport.SportLoad(sports.jsonS);
        }

        

    }
}
