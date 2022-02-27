using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaOnline.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PizzaOnline.Services.ViewModel;
using PizzaOnline.Services.Interfaces;

namespace PizzaOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPizzaService _pizzaService;

        public HomeController(ILogger<HomeController> logger, IPizzaService pizzaService)
        {
            _logger = logger;
            _pizzaService = pizzaService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> PizzaOnline()
        {
            List<PizzasViewModels> model = await _pizzaService.GetAllAsync();
            return View(model);
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
