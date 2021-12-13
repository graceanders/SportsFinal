using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public interface ISports
    {
        string SportName { get;  set; }
        string SportDescription { get; set; }
        List<Sports> SportsList { get; set; }

        void SaveSports(Sports s) { }

        void LoadSports() { }
    }

}
