using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
