using BigBazaarDL;
using BigBazaarManagementSystemMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using BigBazaarBL;

namespace BigBazaarManagementSystemMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBigBazaarBL entity;

        public AdminController(IBigBazaarBL entity)
        {
            this.entity = entity;
        }


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
