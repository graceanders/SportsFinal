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
            Assert.AreEqual(TeamViewModel.TeamOne[0].Name, TeamViewModel.PlayerNameOne);
        }

        [TestMethod]
        public void ExecuteRemovePlayerTest()
        {
            //Arrange

            //Act
            TeamViewModel.PlayerNameOne = "Tim";
            TeamViewModel.PlayerNumberOne = 8;
            TeamViewModel.AddPlayerTeamOne.Execute(null);

            int beforeremove = TeamViewModel.team.TeamOne.Count;

            TeamViewModel.RemovePlayerTeamOne.Execute(null);

            int afterremove = TeamViewModel.TeamOne.Count;

            //Assert
            Assert.AreEqual(beforeremove, 1);
            Assert.AreEqual(afterremove, 0);
            Assert.IsFalse(TeamViewModel.TeamOne.Contains(TeamViewModel.playerone));
        }
    }
}
