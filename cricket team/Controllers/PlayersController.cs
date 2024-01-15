using cricket_team.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace cricket_team.Controllers
{
    public class PlayersController : Controller
    {
        static List<Players> Players = new List<Players>()
        {

        new Players() { PId = 1,PName = "King Kholi",PCountry = "India",PType = "Batter"},
        new Players() { PId = 2,PName = "Dhoni",PCountry = "India",PType = "Batter"},
        new Players() { PId = 3,PName = "gayle",PCountry = "WI",PType = "Batter"},
        new Players() { PId = 4,PName = "Steyn",PCountry = "SA",PType = "Bowler"},
        new Players() { PId = 5,PName = "Miller",PCountry = "SA",PType = "Batter"}

        };
        public IActionResult Index()
        {
            return View(Players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Players());
        }
        [HttpPost]
        public IActionResult Create(Players pro)
        {
            if (ModelState.IsValid)
            {
                Players.Add(pro);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
