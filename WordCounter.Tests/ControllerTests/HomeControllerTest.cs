using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordMaster.Controllers;
using WordMaster.Models;

namespace WordMaster.Tests
{
    [TestClass]
    public class HomeControllerTest
    {

      [TestMethod]
      public void HomeController_Index_ReturnsCorrectView_True()
      {
        //Arrange
        HomeController controller = new HomeController();

        //Act
        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

     

    }
}
