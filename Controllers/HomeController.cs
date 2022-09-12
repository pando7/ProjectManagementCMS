using Microsoft.AspNetCore.Mvc;

namespace ProjectManagementCMS_Blazor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
