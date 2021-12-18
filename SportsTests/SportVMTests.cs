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
        public void Test()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
