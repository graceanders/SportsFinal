using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SportsLibrary
{
    public class JSONSerialization : IJSONSerialization //I don't understand wrapping classes
    {

        class InnerClass //https://www.c-sharpcorner.com/blogs/wrapper-class-in-c-sharp1
        {

            //public T JsonDeserialize<T>(string toDeserialize)
            //{
            //    return JsonConvert.DeserializeObject<T>(toDeserialize);
            //}

            //public string JsonSerialize<T>(this T toSerialize)
            //{
            //    return JsonConvert.SerializeObject(toSerialize);
            //}
        }

        class SaveLoad
        {
            //public string GetXML<T>(this T o)
            //{
            //    XmlSerializer serializer = new XmlSerializer(o.GetType());

            //    using (StringWriter textWriter = new StringWriter())
            //    {
            //        serializer.Serialize(textWriter, o);
            //        return textWriter.ToString();
            //    }
            //}

            public T LoadFromXML<T>(string xml)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StringReader textReader = new StringReader(xml))
                {

                    return (T)serializer.Deserialize(textReader);
                }
            }
        }
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
    }

}
