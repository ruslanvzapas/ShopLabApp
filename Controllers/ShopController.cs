using Microsoft.AspNetCore.Mvc;

namespace ShopLabApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Головна сторінка магазину
        }

        public IActionResult LightroomPresets()
        {
            return View(); // Підсторінка для Lightroom Presets
        }

        public IActionResult Gifts()
        {
            return View(); // Підсторінка для Gifts
        }
    }
}