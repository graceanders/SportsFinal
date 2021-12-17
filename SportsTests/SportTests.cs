using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SportsLibrary;
using System.Collections.Generic;

namespace SportsTests
{
    [TestClass]
    public class SportTests
    {

        [TestMethod]
        public void BasketballTests()
        {
            //Arrange
            Basketball b;

            //Act
            b = new Basketball();

            //Assert
            Assert.AreEqual(b.SportName, "Basketball");
            Assert.AreEqual(b.SportDescription, "a game played between two teams of five players each on a rectangular court, usually indoors. Each team tries to score by tossing the ball through the opponent's goal, an elevated horizontal hoop and net called a basket.");

        }

        [TestMethod]
        public void HockeyTests()
        {
            //Arrange
            Hockey h;

            //Act
            h = new Hockey();

            //Assert
            Assert.AreEqual(h.SportName, "Hockey");
            Assert.AreEqual(h.SportDescription, "a game between two teams, each usually having six players, who wear skates and compete on an ice rink. The object is to propel a vulcanized rubber disk, the puck, past a goal line and into a net guarded by a goaltender, or goalie.");

        }

        [TestMethod]
        public void NewSportTest()
        {
            //Arrange
            Sport s;

            //Act
            s = new Sport("Volleyball", "a game played by two teams, usually of six players on a side, in which the players use their hands to bat a ball back and forth over a high net, trying to make the ball touch the court within the opponents' playing area before it can be returned.");

            //Assert
            Assert.AreEqual(s.SportName, "Volleyball");
            Assert.AreEqual(s.SportDescription, "a game played by two teams, usually of six players on a side, in which the players use their hands to bat a ball back and forth over a high net, trying to make the ball touch the court within the opponents' playing area before it can be returned.");

        }

        [TestMethod]
        public void AddSportTest()
        {
            //Arrange
            SportsRepo sr;
            Sport s;

            //Act
            sr = new SportsRepo();
            s = new Sport("Volleyball", "a game played by two teams, usually of six players on a side, in which the players use their hands to bat a ball back and forth over a high net, trying to make the ball touch the court within the opponents' playing area before it can be returned.");

            sr.AddSport(s);

            //Assert
            Assert.IsTrue(sr.ListOfSports.Contains(s));

        }

        [TestMethod]
        public void AddSportByName()
        {
            //Arrange
            SportsRepo sr;
            Sport s;

            //Act
            sr = new SportsRepo();
            s = new Sport("Volleyball", "a game played by two teams, usually of six players on a side, in which the players use their hands to bat a ball back and forth over a high net, trying to make the ball touch the court within the opponents' playing area before it can be returned.");

            sr.AddSport("Volleyball", "a game played by two teams, usually of six players on a side, in which the players use their hands to bat a ball back and forth over a high net, trying to make the ball touch the court within the opponents' playing area before it can be returned.");

            //Assert
            Assert.AreEqual(sr.ListOfSports[2].SportName, s.SportName);
        }

        [TestMethod]
        public void RemoveSportByNameTest()
        {
            //Arrange
            SportsRepo sr;

            //Act
            sr = new SportsRepo();
            int count = sr.ListOfSports.Count;

            sr.RemoveSport("Basketball", "a game played between two teams of five players each on a rectangular court, usually indoors. Each team tries to score by tossing the ball through the opponent's goal, an elevated horizontal hoop and net called a basket.");

            //Assert
            Assert.AreEqual(count, 2);
            Assert.AreEqual(sr.ListOfSports.Count, 1);
        }

        [TestMethod]
        public void Test()
        {
            //Arrange
            SportsRepo sr;
            Basketball b;

            //Act
            b = new Basketball();
            sr = new SportsRepo();

            sr.RemoveSport(b);

            //Assert
            Assert.IsFalse(sr.ListOfSports.Contains(b));
        }


        [TestMethod]
        public void SportSaveAndLoadTest()
        {
            //Arrange
            SportsRepo sr;
            Sport b;
            
            //Act
            sr = new SportsRepo();
            b = new Basketball();

            List<Sport> sports = sr.ListOfSports;
            sr.SerializableSport.SportSave(); //jsonS
            string newtonsoft;

            //Assert
            newtonsoft = JsonConvert.SerializeObject(b);
            Assert.AreEqual(sr.jsonS, newtonsoft);
        }
    }
    
}
