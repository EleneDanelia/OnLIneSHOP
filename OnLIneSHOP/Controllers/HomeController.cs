using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Completion;
using OnLIneSHOP.Models;
using System.Diagnostics;

namespace OnLIneSHOP.Controllers
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
			return View();
		}
		[HttpPost]
		public IActionResult Check(User user)
		{
			if (ModelState.IsValid)
			{ 
				return Redirect("/");
			}
		    return View("Index");
		}
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult OnLineSHOP()
        {
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
