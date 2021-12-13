using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class Player : Person
    {
        /*
         Requirement : Players have names, numbers. Players may be a subclass of person. 

         Requirement : add update players details Number, Name
         */

        //possiblly add position?

        public string Name { get; set; }
        public int Number { get; set; }

        public string SportPlayed{ get; set; }

        public Player (string Name, int Number)
        {
            this.Name = Name;
            this.Number = Number;
        }

    }
}
