using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create(User user)
        {
            return View();
        }
        public IActionResult Detail(int userId)
        {
            return View();
        }
    }
}
