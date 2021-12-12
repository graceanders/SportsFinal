using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class Sports: ISports
    {
        /*
         Requirement : App should have a collection of sport objects (maybe sport repo)  and the ability to add an remove sports

         Requirement : Sports have names and descriptions. 

         different sports will likely need different sub classes to support different structures.

         app should demonstrate different sports.
         */

        public string SportName { get; set; }
        public string SportDescription { get; set; }
        public List <Sports> SportsList { get; set; }

        public Sports() { }

        public Sports (string Name, string Description)
        {
            this.SportName = Name;
            this.SportDescription = Description;
        }

        public virtual string About()
        {
            return string.Format($"The sport is {SportName}\nIt is {SportDescription}");
        }
    }
}
