using Microsoft.AspNetCore.Mvc;

namespace ShopLabApp.Controllers
{
    public class TipsController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Блог з порадами
        }
    }
}