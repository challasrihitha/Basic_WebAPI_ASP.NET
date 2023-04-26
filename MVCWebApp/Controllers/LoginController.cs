using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCWebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public ActionResult Login()
        {
            return View();
        }

        public List<User> PutValue()
        {
            var users = new List<User>
            {
                new User{UserId=1,username="srihitha",password = "100"},
                new User{UserId=2,username="neha",password = "101"},
                new User{UserId=3,username="priya",password = "102"},
                new User{UserId=4,username="preethi",password = "103"}
            };

            return users;
        }

        [HttpPost]
        public ActionResult Verify(User usr)
        {
            var u = PutValue();
            var ue = u.Where( u => u.username.Equals(usr.username));
            var up = ue.Where(p => p.password.Equals(usr.password));
            if(up.Count()==1)
            {
                ViewBag.message = "Login  is Success";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }

        }
       

    }
}

