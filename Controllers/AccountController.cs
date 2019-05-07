using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPhone.Data;
using SmartPhone.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Controllers
{
    [Route("account")]
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
        public async Task<IActionResult> HomeLogin(UserView model)
        {
            var auth = _context.Users.FirstOrDefault(x => (x.Username == model.Username | x.Email == model.Username) & x.Password == model.Password & x.RoleId == 2);
            if(auth != null)
            {
                ViewBag.Erro = "";
                HttpContext.Session.SetString("Customer", auth.Name);
                HttpContext.Session.SetInt32("CustomerID", auth.Id);
                HttpContext.Session.Remove("Discount");
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Erro = "Tài khoản hoặc mật khẩu không đúng!";
            return View(model);
        }

        [HttpGet, Route("logout")]
        public async Task<IActionResult> HomeLogout()
        {
            HttpContext.Session.Remove("CustomerID");
            HttpContext.Session.Remove("Discount");
            return RedirectToAction("Index", "Home");
        }
    }
}
