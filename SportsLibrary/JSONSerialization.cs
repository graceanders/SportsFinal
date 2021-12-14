using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SportsLibrary
{
    public class JSONSerialization : IJSONSerialization
    {
        public string jsonS, jsonT, jsonSport, jsonTeam;

        public void SaveSport(object o)
        {
            jsonS = JsonConvert.SerializeObject(o);
        }

        public void LoadSport(object o)
        {
            var jsonSport = JsonConvert.DeserializeObject<Sports>(jsonS);
            o = jsonSport;
        }

        public void SaveTeam(object o)
        {
            jsonT = JsonConvert.SerializeObject(o);
        }

        public void LoadTeam(object o)
        {
            var jsonTeam = JsonConvert.DeserializeObject<Teams>(jsonT);
            o = jsonTeam;
        }
    }
}
