using Microsoft.AspNetCore.Mvc;

namespace ShopLabApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View(); // Сторінка логіну
        }

        public IActionResult Register()
        {
            return View(); // Сторінка реєстрації
        }

        public IActionResult Profile()
        {
            return View(); // Сторінка профілю
        }
    }
}