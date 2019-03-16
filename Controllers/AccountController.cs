using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Models;
using Microsoft.AspNetCore.Http;
using SmartPhone.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using SmartPhone.ViewModels;

namespace SmartPhone.Controllers
{
    [Route("")]
    public class AccountController : Controller
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }


        [HttpGet, Route("login")]
        public IActionResult HomeLogin(string returnUrl = "")
        {
            var model = new UserView { ReturnUrl = returnUrl };

            return View(model);
        }

        [HttpPost, Route("login")]
        public async Task<IActionResult> Login(UserView model)
        {
            var auth = _context.Users.FirstOrDefault(x => x.Username == model.Username & x.Password == model.Password);
            if(auth != null)
            {
                HttpContext.Session.SetString("Customer", auth.Name);
                HttpContext.Session.SetInt32("CustomerID", auth.Id);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet, Route("logout")]
        public async Task<IActionResult> HomeLogout()
        {
            HttpContext.Session.Remove("CustomerID");
            return RedirectToAction("Index", "Home");
        }




        //-------------------------------------------------------- Admin -------------------------------------------------------


    }
}
