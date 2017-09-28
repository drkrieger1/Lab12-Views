using Lab12Erik.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12Erik.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Student one = new Student
            {
                Name = "Erik",
                Age = 25,
                Class = "ASP.NETCORE"
            };

            return View(one);
        }

        [Route("Register")]
        public ViewResult Register()
        {
            return View(); 
        }
    }
}
