using Microsoft.AspNetCore.Mvc;

namespace DotNetCore8MvcWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
