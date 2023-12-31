using eticaretb.Data;
using eticaretb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eticaretb.Controllers
{
	[ApiController]
	[Route("[controller]")]

	public class UrunlerController : Controller
	{
		private readonly ILogger<UrunlerController> _logger;
		private readonly eticaretbContext db;

	


		public UrunlerController(ILogger<UrunlerController> logger, eticaretbContext context)
		{
			_logger = logger;
			db = context;

		}

		public IActionResult Urunler()
		{
			ViewBag.product = db.Urun.OrderBy(a => a.ID).Take(16);


			return View();
		}

		
	}
}
