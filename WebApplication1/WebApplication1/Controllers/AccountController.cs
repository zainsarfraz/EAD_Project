﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        //sign in sign up 

        public IActionResult adminLogin()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
