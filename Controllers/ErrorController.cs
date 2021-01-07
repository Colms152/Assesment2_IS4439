using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventchain.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(int code)
        {
            if (code == 404)
            {
                ViewBag.error = code;
                return View("HttpError");
            }
            return View("HttpError");
        }
    }
}
