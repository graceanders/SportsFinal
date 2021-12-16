﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class Sport: ISport
    {

        public string SportName { get; set; }
        public string SportDescription { get; set; }
        

        public Sport()
        {
        }


        public Sport (string Name, string Description)
        {
            this.SportName = Name;
            this.SportDescription = Description;
        }

     
    }

    public class SerializableSport : Sport
    {
        public void SportSave()
        {
            string json = SaveLoad.JsonSerialize<Sport>(this);
        }

        public void SportLoad(string jsonSport)
        {
            Sport s = SaveLoad.JsonDeserialize<Sport>(jsonSport);
            this.SportName = s.SportName;
            this.SportDescription = s.SportDescription;
        }
    }
}
