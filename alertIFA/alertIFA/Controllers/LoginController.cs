using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace alertIFA.Controllers
{
    public class LoginCOntroller : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}