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
            Player jim;

            //Act
            pr = new PlayerRepo();
            jim = new Player("Jim", 7);

            //Team one not adding correctly
            pr.AddPlayer(jim.TeamOne, jim);
            int afteradd = jim.TeamOne.Count;

            pr.RemovePlayer(jim.TeamOne, jim);
            int afterremove = jim.TeamOne.Count;

            //Assert
            Assert.AreEqual(afteradd, 1);
            Assert.AreEqual(afterremove, 0);
        }

        [TestMethod]
        public void RemovePlayerByNameTests()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void AddPlayerTests()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void AddPlayerByNameTests()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
