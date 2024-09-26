using Microsoft.AspNetCore.Mvc;

namespace ShopLabApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Сторінка контактів
        }
    }
}