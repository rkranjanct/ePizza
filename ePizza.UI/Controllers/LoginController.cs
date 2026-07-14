using ePizza.UI.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.UI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel request)
        {
            return View();
        }
    }
}
