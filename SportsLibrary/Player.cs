using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class Player : IPlayer
    {

        public string Name { get; set; }
        public int Number { get; set; }

        public Player playerone;
        public Player playertwo;

        public Player() { }

        public Player (string Name, int Number)
        {
            this.Name = Name;
            this.Number = Number;
        }

    }
}
