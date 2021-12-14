using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface IJSONSerialization
    {
        public void  SaveSport(object o);

        public void LoadSport(object o);

        public void SaveTeam(object o);

        public void LoadTeam(object o);
    }
}
