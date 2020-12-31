using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eventchain.Controllers
{
    [Authorize]
    public class PrivateController : Controller
    {
        // GET: /<controller>/
        
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult UserAgreement()
        {
            return View();
        }
    }
}
