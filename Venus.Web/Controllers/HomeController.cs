using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Venus.Web.Controllers {

    public class HomeController : Controller {
        
        public IActionResult Index() {
            return View();
        }
        
        public IActionResult Authenticated() {
            return View();
        }
    }
}