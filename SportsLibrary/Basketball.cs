﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class Basketball: Sports
    {
        public Basketball()
        {

            //Turn these into get sets and then...
            this.SportName = "Name";
            this.SportDescription = "a game played between two teams of five players each on a rectangular court, usually indoors. Each team tries to score by tossing the ball through the opponent's goal, an elevated horizontal hoop and net called a basket.";


            //Do this from the view?
            Sports Basketball = new Basketball();

            AddSport(Basketball);

        }
    }
}
