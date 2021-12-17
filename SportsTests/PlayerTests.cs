using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void RemovePlayerTests()
        {
            //Arrange
            PlayerRepo pr;
            Team team;
            Player jim;

            //Act
            pr = new PlayerRepo();
            team = new Team();
            jim = new Player("Jim", 7);

            pr.AddPlayer(team.TeamOne, jim);

            int afteradd = team.TeamOne.Count;

            pr.RemovePlayer(team.TeamOne, jim);
            int afterremove = team.TeamOne.Count;

            //Assert
            Assert.AreEqual(afteradd, 1);
            Assert.AreEqual(afterremove, 0);
        }

        [TestMethod]
        public void RemovePlayerByNameTests()
        {
            //Arrange
            PlayerRepo pr;
            Team team;

            //Act
            pr = new PlayerRepo();
            team = new Team();

            pr.AddPlayer(team.TeamOne, "Jim", 7);

            int afteradd = team.TeamOne.Count;

            pr.RemovePlayer(team.TeamOne, "Jim", 7);
            int afterremove = team.TeamOne.Count;

            //Assert
            Assert.AreEqual(afteradd, 1);
            Assert.AreEqual(afterremove, 0);
        }

        [TestMethod]
        public void AddPlayerTests()
        {
            //Arrange
            PlayerRepo pr;
            Team team;
            Player jim;

            //Act
            pr = new PlayerRepo();
            team = new Team();
            jim = new Player("Jim", 7);

            int beforeadd = team.TeamOne.Count;
            pr.AddPlayer(team.TeamOne, jim);
            int afteradd = team.TeamOne.Count;

            //Assert
            Assert.AreEqual(beforeadd, 0);
            Assert.AreEqual(afteradd, 1);
        }

        [TestMethod]
        public void AddPlayerByNameTests()
        {
            //Arrange
            PlayerRepo pr;
            Team team;

            //Act
            pr = new PlayerRepo();
            team = new Team();

            int beforeadd = team.TeamOne.Count;
            pr.AddPlayer(team.TeamOne, "Jim", 7);
            int afteradd = team.TeamOne.Count;

            //Assert
            Assert.AreEqual(beforeadd, 0);
            Assert.AreEqual(afteradd, 1);
        }
    }
}
