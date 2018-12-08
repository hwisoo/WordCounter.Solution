using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordMaster.Controllers;
using WordMaster.Models;

namespace WordMaster.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {

      [TestMethod]
      public void WordController_Index_ReturnsCorrectView_True()
      {
        //Arrange
        WordCounterController controller = new WordCounterController();

        //Act
        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void WordController_Result_ReturnsCorrectView_True()
      {
        //Arrange
        WordCounterController controller = new WordCounterController();

        //Act
        ActionResult resultView = controller.Result("cat", "cat cat cat");

        //Assert
        Assert.IsInstanceOfType(resultView, typeof(ViewResult));
      }

 

    }
}
