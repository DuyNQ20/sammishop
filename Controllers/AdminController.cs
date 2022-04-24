using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sammishop.Data;
using Sammishop.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace  Sammishop.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        private readonly DataContext _context;

        public AdminController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
                return RedirectToAction(nameof(AdminLogin));
            return View();
        }

        [HttpGet, Route("login")]
        public IActionResult AdminLogin(string returnUrl = "")
        {
            var model = new UserView { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost, Route("login")]
        public IActionResult AdminLogin(UserView model)
        {
            var auth = _context.Users.FirstOrDefault(x => (x.Username == model.Username | x.Email == model.Username) & x.Password == model.Password & (x.RoleId == 1 || x.RoleId == 3));
            if (auth != null)
            {
                ViewBag.Erro = "";
                HttpContext.Session.SetString("Admin", auth.Name);
                HttpContext.Session.SetInt32("AdminID", auth.Id);
                return RedirectToAction("Index", "Products");
            }
            ViewBag.Erro = "Tài khoản hoặc mật khẩu không đúng!";
            return View(model);

        }
        [HttpGet, Route("logout")]
        public async Task<IActionResult> AdminLogout()
        {
            HttpContext.Session.Remove("AdminID");
            return RedirectToAction(nameof(AdminLogin));
        }
    }
}