using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
    public class EngineersController : Controller
    {
        private readonly FactoryContext _db;
        public EngineersController(FactoryContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Engineer> model = _db.Engineers.ToList();
            ViewBag.PageTitle = "All Engineers";
            return View();
        }
    }
}