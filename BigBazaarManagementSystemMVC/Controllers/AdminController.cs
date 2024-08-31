using BigBazaarDL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using BigBazaarBL;
using Entities;


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

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
    
        public async Task<IActionResult> AddCategory(Category cat) {

            
                try
                {
                    Category category = new Category();
                    category.CatName=cat.CatName;

                    bool val = await entity.AddCategory(category);

                    if (val)
                    {
                        return Json("Category Saved Successfully");
                    }
                    else
                    {
                        return Json("Failed to Add a new category, Please Try Again Later!!");
                    }

                }catch(Exception e)
                {
                    return Json("Something went wrong!!");
                }
            
            
        }
    }
}
