using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyTodo_API.Controllers
{
    public class LogOnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LogOn(string userName, string password)
        {


            return Ok(userName);
        }

    }
}