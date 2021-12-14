using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface ISports: IJSONSerialization
    {
        string SportName { get;  set; }
        string SportDescription { get; set; }
        List<Sports> SportsList { get; set; }

        void AddSport(Sports s);
    }

}
