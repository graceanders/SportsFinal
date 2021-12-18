using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTests
{
    [TestClass]
    public class SportVMTests
    {
        SportViewModel SportViewModel;

        public SportVMTests()
        {
            SportViewModel = new SportViewModel(new SportsLibrary.SportsRepo(), new SportsLibrary.TeamsRepo());
        }

        [TestMethod]
        public void ExecuteAddSportTest()
        {
            //Arrange

            //Act
            SportViewModel.SportName = "Vollyball";
            SportViewModel.SportDescription = "Hit ball";
            SportViewModel.AddSport.Execute(null);

            //Assert
            Assert.AreEqual(SportViewModel.ListOfSports[2].SportName, SportViewModel.SportName);
        }

        [TestMethod]
        public void ExecuteRemoveSportTest()
        {
            //Arrange

            //Act
            SportViewModel.SportName = "Basketball";
            SportViewModel.SportDescription = "a game played between two teams of five players each on a rectangular court, usually indoors. Each team tries to score by tossing the ball through the opponent's goal, an elevated horizontal hoop and net called a basket.";
            int beforeremove = SportViewModel.ListOfSports.Count;

            SportViewModel.RemoveSport.Execute(null);

            int afterremove = SportViewModel.ListOfSports.Count;

            //Assert
            Assert.AreEqual(beforeremove, 2);
            Assert.AreEqual(afterremove, 1);
        }



        [TestMethod]
        public void ExecuteAddTeamTest()
        {
            //Arrange

            //Act
            SportViewModel.TeamName = "Pumas";
            SportViewModel.NumberOfPlayers = 25;
            SportViewModel.AddTeam.Execute(null);

            //Assert
            Assert.AreEqual(SportViewModel.ListOfTeams[0].TeamName, SportViewModel.TeamName);
        }

        [TestMethod]
        public void ExecuteRemoveTeamTest()
        {
            //Arrange

            //Act
            SportViewModel.TeamName = "Pumas";
            SportViewModel.NumberOfPlayers = 25;
            SportViewModel.AddTeam.Execute(null);

            int beforeremove = SportViewModel.ListOfTeams.Count;

            SportViewModel.RemoveTeam.Execute(null);

            int afterremove = SportViewModel.ListOfTeams.Count;

            //Assert
            Assert.AreEqual(beforeremove, 1);
            Assert.AreEqual(afterremove, 0);
        }
    }
}
