using Microsoft.AspNetCore.Mvc;

namespace ShopLabApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Сторінка про автора
        }
    }
}