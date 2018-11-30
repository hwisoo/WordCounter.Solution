using Microsoft.AspNetCore.Mvc;

namespace WordMaster.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}