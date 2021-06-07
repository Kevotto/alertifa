using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alertIFA.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Banque()
        {
            return View();
        }

        public IActionResult Commerce()
        {
            return View();
        }

        public IActionResult General()
        {
            return View();
        }
        public IActionResult Gestion()
        {
            return View();
        }
        public IActionResult Informatique()
        {
            return View();
        }
        public IActionResult Ressources_humaines()
        {
            return View();
        }
    }
}
