using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    interface ITeamRepo
    {
        List<Team> ListOfTeams { get; set; }

        void AddTeam(Team t);
        void AddTeam(string Name, int NumberOfPlayers);

        void RemoveTeam(string Name, int NumberOfPlayers);
        void RemoveTeam(Team t);

        void SaveTeam();
        void LoadTeam();

    }
}
