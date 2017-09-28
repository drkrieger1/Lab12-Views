using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12Erik.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error")]
        public ViewResult Index()
        {
            string errorMessage = "Somthing went wrong";
            ViewData["msg"] = errorMessage;
            return View();
        }
    }
}
