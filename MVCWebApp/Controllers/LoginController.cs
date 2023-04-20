using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCWebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{id=1,username="srihitha",password = "100"},
                new UserModel{id=2,username="neha",password = "101"},
                new UserModel{id=3,username="priya",password = "102"},
                new UserModel{id=4,username="preethi",password = "103"}
            };

            return users;
        }
    }
}

