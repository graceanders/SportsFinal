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
        

        public Sports()
        {
        }


        public Sports (string Name, string Description)
        {
            this.SportName = Name;
            this.SportDescription = Description;
        }

     
    }
}
