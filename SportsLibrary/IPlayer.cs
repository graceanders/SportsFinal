using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface IPlayer: IPerson
    {
        int PlayerNumber { get; set; }

        List<Player> TeamOne { get; set; }
        List<Player> TeamTwo { get; set; }

    }
}
