using Microsoft.AspNetCore.Mvc;

namespace SmartPhone.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}