using Microsoft.AspNetCore.Mvc;

namespace Training.Web.Areas.BootStrapForm.Controllers
{
    [Area("BootStrapForm")]
    public class BootStrapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
