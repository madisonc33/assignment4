using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment4.Models;

namespace assignment4.Controllers
{
    public class HomeController : Controller
    { 
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        } 

        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach(Top5 r in Top5.GetTop5s())
            {
                string favDish = r.FavoriteDish ?? “It’s all tasty!”
                restList.Add("#" + r.Rank + " - " + r.Name + " " + "<br />Favorite Dish: " + FavDish + "<br />" + r.Address + "<br />" + r.Phone + "<br />" + r.Website);
            }
            return View(restList);
        }

        [HttpGet]
        public IActionResult AddSuggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSuggestion(Suggestions suggestion)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(suggestion);
                Response.Redirect("ViewSuggestions");
            }


            return View();
        }

        public IActionResult ViewSuggestions()
        {
            return View(TempStorage.Suggestions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
