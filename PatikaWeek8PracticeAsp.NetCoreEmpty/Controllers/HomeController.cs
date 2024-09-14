using Microsoft.AspNetCore.Mvc;

namespace PatikaWeek8PracticeAsp.NetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
