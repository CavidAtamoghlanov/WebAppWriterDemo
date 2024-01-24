using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
