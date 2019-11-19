using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnotherProject.Models;
using AnotherProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AnotherProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        
        public async Task<IActionResult> Catalog()
        {
            //sends tables list to the model
            var categories = _context.Category;
            return View(await categories.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CompleteRequest()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }

        public async Task<IActionResult> Products(int? id)
        {
            var component = _context.Component.Where(x => x.CategoryID == id);
            return View(await component.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> UserTest()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
    }
}
