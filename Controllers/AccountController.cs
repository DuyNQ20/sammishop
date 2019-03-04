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
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        public AccountController(UserManager<User> userManager, IConfiguration configuration, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _signInManager = signInManager;

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
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username,
                   model.Password, true, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View(model);
        }

        [HttpPost, Route("register")]
        public async Task<IActionResult> Register([FromBody] UserView model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { Email = model.Username, UserName = model.Username };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();
        }

        [HttpGet, Route("logout")]
        public async Task<IActionResult> HomeLogout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
