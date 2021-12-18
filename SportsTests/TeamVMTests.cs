using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsApp.ViewModels;
using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTests
{
    [TestClass]
    public class TeamVMTests
    {
        TeamViewModel TeamViewModel;

        public TeamVMTests()
        {
            TeamViewModel = new TeamViewModel (new PlayerRepo());
        }

        [TestMethod]
        public void ExecuteAddPlayerTest()
        {
            //Arrange

            //Act
            TeamViewModel.PlayerNameOne = "Tim";
            TeamViewModel.PlayerNumberOne = 8;
            TeamViewModel.AddPlayerTeamOne.Execute(null);

            //Assert
            Assert.AreEqual(TeamViewModel.team.TeamOne[0].Name, TeamViewModel.PlayerNameOne);
        }
    }
}
