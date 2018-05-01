using System.Diagnostics;
using HotelsGarden.Models;
using HotelsGarden.Models.View;
using HotelsGarden.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelsGarden.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IExpediaService expediaService)
        {
            this.expediaService = expediaService;
        }

        private readonly IExpediaService expediaService;

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Index());
        }

        [HttpPost]
        public IActionResult Index(Index model)
        {
            var offers = expediaService.GetOffersAsync(model.Filters).Result;

            return View(new Index { Offers = offers });
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
