using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebJourneys.Data;
using WebJourneys.Models;

namespace WebJourneys.Controllers
{
	public class HomeController : Controller
	{
		private IRepository _repo;
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, IRepository repo)
		{
			_logger = logger;
			_repo = repo;
		}

		public IActionResult Index()
		{
			var vm = _repo.GetAllPoints();
			return View(vm);
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
