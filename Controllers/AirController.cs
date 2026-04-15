using Microsoft.AspNetCore.Mvc;

namespace Nazi.Controllers
{
    public class AirController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
