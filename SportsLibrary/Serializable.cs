using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SportsLibrary
{
    public static class Serializable
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
}
