using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCWebApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: /<controller>/
        public ActionResult Register()
        {
            return View();
        }
         public List<User> PutValue()
        {
            var users = new List<User>
            {
                new User{UserId=1,username="srihitha",password = "100",ConfirmPassword= "100"},
                
            };

            return users;
        }

        [HttpPost]
        public ActionResult check(User usr)
        {
            var u = PutValue();
            var ue = u.Where(u => u.username.Equals(usr.username));
            var up = ue.Where(p => p.password.Equals(usr.password));
            var ucp = up.Where(cp => cp.ConfirmPassword.Equals(usr.ConfirmPassword));
            if (up.Count() == 1)
            {
                ViewBag.message = "Registration  is Success";
                return View("RegisterSuccess");
            }
            else
            {
                ViewBag.message = "Registration Failed";
                return View("Register");
            }

        }


    }
}

