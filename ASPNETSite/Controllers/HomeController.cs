using Microsoft.AspNetCore.Mvc;

namespace ASPNETSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
