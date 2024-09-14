using BigBazaarDL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using BigBazaarBL;
using Entities;
using BigBazaarManagementSystemMVC.Models;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;


namespace BigBazaarManagementSystemMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBigBazaarBL entity;
        private readonly ICompositeViewEngine _viewEngine;
        

        public AdminController(IBigBazaarBL entity)
        {
            this.entity = entity;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddCategory()
        {

            try
            {
                List<Category> list = await entity.GetCategories();

                List<CategoryModel> modelList = list.Select(item => new CategoryModel { CatId = item.CatId, CatName = item.CatName }).ToList();

                ViewBag.ModelList = modelList;

                return View();
            }
            catch (Exception e)
            {
                return Json("Something wentwrong", e);
            }
        }

        [HttpPost]
        public async Task<JsonResult> AddingCategory(CategoryModel cat) {

            if (ModelState.IsValid)
            {

                try
                {
                    Category category = new Category();
                    category.CatName = cat.CatName;

                    bool val = await entity.AddCategory(category);

                    if (val)
                    {
                        return Json("Category Saved Successfully");
                    }
                    else
                    {
                        return Json("Failed to Add a new category, Please Try Again Later!!");
                    }

                }
                catch (Exception e)
                {
                    return Json("Something went wrong!!", e);
                }
            }
            else
            {
                return Json("Something went wrong!!");
            }
            
            
        }

        [HttpGet]

        public async Task<IActionResult> ViewCategory()
        {
            try
            {
                List<Category> list = await entity.GetCategories();

                List<CategoryModel> modelList=list.Select(item=>new CategoryModel { CatId=item.CatId,CatName=item.CatName}).ToList();

                ViewBag.ModelList = modelList;

                return View();
            }
            catch(Exception e)
            {
                return Json("Something wentwrong",e);
            }
        }

       


    }
}

