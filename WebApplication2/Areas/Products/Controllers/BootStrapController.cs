using Microsoft.AspNetCore.Mvc;

namespace Training.Web.Areas.Products.Controllers
{
    [Area("Products")]
    public class BootStrapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
