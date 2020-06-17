using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CHiRP.Controllers
{
    public class CompanionBotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}