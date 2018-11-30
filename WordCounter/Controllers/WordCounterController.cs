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
  

  }
}