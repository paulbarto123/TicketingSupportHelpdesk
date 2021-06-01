using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Login/index.cshtml");
        }

<<<<<<< HEAD
        //public RedirectResult New()
        //{
        //    return Redirect("Views/Home/index.cshtml");
        //}
=======
        public RedirectResult New()
        {
            return Redirect("Views/Home/index.cshtml");
        }
>>>>>>> 877e21e73fe1e41d95b83f38d8a00f8a95857098
    }
}
