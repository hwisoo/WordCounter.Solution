using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
// using WordMaster.Models;

namespace WordMaster.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
     
      return View();
    }

     [HttpPost("/wordcounter")]
    public ActionResult Result(string inputWord, string inputSentence)
    {
      WordCounter newWordCounter = new WordCounter(inputWord, inputSentence);
      
      return View("Result", newWordCounter);
    }
  
  

  }
}