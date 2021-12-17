using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface ITeam
    {
        string TeamName { get; set; }
        int NumberOfPlayers { get; set; }

        Sport TeamsSport { get; set; }
    }
}
