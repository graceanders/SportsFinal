using System;
using System.Collections.Generic;
using System.Text;

namespace SportsLibrary
{
    public class TeamsRepo
    {
        public Team teams;
        public SerializableTeam SerializableTeam;

        public TeamsRepo()
        {
            teams = new Team();
        }

        public void SaveTeam()
        {
            SerializableTeam.TeamsSave();
        }

        public void LoadTeam()
        {
            SerializableTeam.TeamLoad(teams.jsonT);
        }
    }
}
