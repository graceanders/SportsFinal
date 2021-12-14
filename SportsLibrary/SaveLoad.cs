using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public static class SaveLoad
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
