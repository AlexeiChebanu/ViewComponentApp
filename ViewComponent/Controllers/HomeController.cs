using Microsoft.AspNetCore.Mvc;
using ViewComponentApp.Model;

namespace ViewComponentApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("friends-list")]
        public IActionResult LoadFriendsList()
        {
            PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Friends",
                Persons = new List<Person>()
                {
                    new Person() {PersonName = "Alex", JobTitle = "IT"},
                    new Person() {PersonName= "Nicole", JobTitle = "Surgeon"},
                    new Person() {PersonName = "Sandro", JobTitle = "Sailor"}
                }
            };

            return ViewComponent("Grid", new { grid = personGridModel });
        }
    }
}
