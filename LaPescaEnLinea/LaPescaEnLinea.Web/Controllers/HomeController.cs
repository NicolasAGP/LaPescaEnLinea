using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaPescaEnLinea.Web.Models;
using LaPescaEnLinea.Models;

namespace LaPescaEnLinea.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContextLPL _dbContext1;

        public HomeController(ILogger<HomeController> logger, DataContextLPL dataContext1)
        {
            _logger = logger;
            _dbContext1 = dataContext1;
        }

        public IActionResult Index()
        {
            var hoteles = _dbContext1.Hoteles.Where(c => c.Estatus == true);
            //_emailSender.SendEmailAsync("nicolas.gonzalez.alexi@gmail.com", "prueba", "");
            return View();
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
