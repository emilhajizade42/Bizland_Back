using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.DAL;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel result = new HomeViewModel()
            {
                ourTeamCards = _context.OurTeamCards.ToList(),
                Settings = _context.Settings.FirstOrDefault()
            };
            return View(result);
        }

      
    }
}
