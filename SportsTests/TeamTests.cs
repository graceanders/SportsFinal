using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTests
{
    [TestClass]
    public class TeamTests
    {
        [TestMethod]
        public void NewTeamTest()
        {
            //Arrange
            Team t;

            //Act
            t = new Team("The Jerzeys", 5);

            //Assert
            Assert.AreEqual(t.TeamName, "The Jerzeys");
            Assert.AreEqual(t.NumberOfPlayers, 5);

        }

        [TestMethod]
        public void AddTeamTest()
        {
            //Arrange
            TeamsRepo tr;
            Team t;

            //Act
            tr = new TeamsRepo();
            t = new Team("The Goldens", 7);

            tr.AddTeam(t);

            //Assert
            Assert.IsTrue(tr.ListOfTeams.Contains(t));

        }

        [TestMethod]
        public void AddTeamByNameTest()
        {
            //Arrange
            TeamsRepo tr;
            Team t;

            //Act
            tr = new TeamsRepo();
            t = new Team("The Goldens", 7);

            tr.AddTeam("The Goldens", 7);

            //Assert
            Assert.AreEqual(tr.ListOfTeams[0].TeamName, t.TeamName);

        }

        [TestMethod]
        public void RemoveTeamTest()
        {
            //Arrange
            TeamsRepo tr;
            Team test;

            //Act
            tr = new TeamsRepo();
            test = new Team("Yellow", 8);

            tr.RemoveTeam(test);

            //Assert
            Assert.IsFalse(tr.ListOfTeams.Contains(test));

        }

        [TestMethod]
        public void RemoveTeamByNameTest()
        {
            //Arrange
            TeamsRepo tr;

            //Act
            tr = new TeamsRepo();
            int emptycount = tr.ListOfTeams.Count;
            tr.AddTeam("Blue Jays", 2);
            int addcount = tr.ListOfTeams.Count;

            tr.RemoveTeam("Blue Jays", 2);
            int afterremoval = tr.ListOfTeams.Count;

            //Assert
            Assert.AreEqual(emptycount, 0);
            Assert.AreEqual(addcount, 1);
            Assert.AreEqual(emptycount, afterremoval);

        }

        [TestMethod]
        public void AssignTeamToSportTest()
        {
            //Arrange
            TeamsRepo tr;
            Sport h;
            Team teamwithsport;

            //Act
            tr = new TeamsRepo();
            h = new Hockey();
            teamwithsport = new Team("Blackhawks", 20, h);

            //Assert
            Assert.AreEqual(teamwithsport.TeamsSport, h);
        }

    }
}
