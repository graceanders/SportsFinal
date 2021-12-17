using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface ISportsRepo
    {
        List<Sport> ListOfSports { get; set; }

        void PopulateSports();

        void AddSport(Sport s);
        void AddSport(string Name, string Description);

        void RemoveSport(string Name, string Description);
        void RemoveSport(Sport s);

        void SaveSport();
        void LoadSport();
    }
}
