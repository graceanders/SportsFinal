using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface IPlayer: IPerson
    {
        int PlayerNumber { get; set; }
    }
}
