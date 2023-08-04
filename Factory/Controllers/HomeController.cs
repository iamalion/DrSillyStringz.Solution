using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.PageTitle = "Dr. Silly Stringz";
        return View();
      }

    }
}