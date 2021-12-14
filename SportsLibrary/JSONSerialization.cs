using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SportsLibrary
{
    class JSONSerialization
    {
        //public string jsonS, jsonT, jsonSport, jsonTeam;

        //public void SaveSport(object o)
        //{
        //    jsonS = JsonConvert.SerializeObject(o);
        //}

        //public void LoadSport(object o)
        //{
        //    var jsonSport = JsonConvert.DeserializeObject<Sports>(jsonS);
        //    o = jsonSport;


        //}

        //public void SaveTeam(object o)
        //{
        //    jsonT = JsonConvert.SerializeObject(o);
        //}

        //public void LoadTeam(object o)
        //{
        //    var jsonTeam = JsonConvert.DeserializeObject<Teams>(jsonT);
        //    o = jsonTeam;
        //}


        class InnerClass //https://www.c-sharpcorner.com/blogs/wrapper-class-in-c-sharp1
        {

            public static T JsonDeserialize<T>(this string toDeserialize)
            {
                return JsonConvert.DeserializeObject<T>(toDeserialize);
            }

            public static string JsonSerialize<T>(this T toSerialize)
            {
                return JsonConvert.SerializeObject(toSerialize);
            }
        }

        public void Load(object o)
        {
            JSONSerialization.InnerClass jsonS = new JSONSerialization.InnerClass();
            return jsonS.JsonDeserialize<T>(o)
        }
    }

    
}
