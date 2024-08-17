using BigBazaarManagementSystemMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBazaarManagementSystemMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCategory(Category cat)
        {
            return View();
        }
    }
}
