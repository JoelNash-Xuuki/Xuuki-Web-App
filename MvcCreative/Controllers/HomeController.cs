using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCreative.Models;

using System.Text.Encodings.Web;

namespace MvcCreative.Controllers
{
    public class HelloWorldController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}

		public string Welcome(string name, int ID = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {ID}");
		}
	}
}
