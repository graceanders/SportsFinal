using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface ITeam
    {
        string TeamName { get; set; }
        int NumberOfPlayers { get; set; }

        List<Player> TeamOne { get; set; }
        List<Player> TeamTwo { get; set; }

        Sport TeamsSport { get; set; }
    }
}
