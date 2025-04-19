using System.Diagnostics;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context; 

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [AllowAnonymous]

        public async Task<IActionResult> Index()
        {
            HomePageViewModel viewModel = new HomePageViewModel();
            var mostViewedBooks = await _context.Books
                .OrderByDescending(b => b.ViewCount)
                .Take(2)
                .ToListAsync();  
            viewModel.MostViewedBooks = mostViewedBooks;
            var newBooks = await _context.Books
                .OrderByDescending(b => b.Created)
                .Take(2)
                .ToListAsync();
            viewModel.NewBooks =newBooks;

            return View(viewModel);
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
