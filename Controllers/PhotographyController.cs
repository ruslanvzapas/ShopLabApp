using Microsoft.AspNetCore.Mvc;

namespace ShopLabApp.Controllers
{
    public class PhotographyController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Галерея фото
        }
    }
}