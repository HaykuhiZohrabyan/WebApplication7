global using WebApplication7.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.ViewModels.Categories;
namespace WebApplication7.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var data = _categoryService.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CategoryAddEdit model)
        {

            var checkCategoryExist = _categoryService.IsExist(model.Name);
            if(checkCategoryExist)
            {
                ModelState.AddModelError("Name", "Category is exist");
                return View(model);
            }
            _categoryService.Add(model);
            //try
            //{
            //_categoryService.Add(model);
            //}
            //catch(Exception ex)
            //{
            //    ModelState.AddModelError("Name", ex.ToString());
            //    return View(model);
            //}
            return RedirectToAction("Index");
        }

        public IActionResult List(int categoryId)
        {
            var model = _productService.GetAllByCategory(categoryId);
            return View(model);
        }
    }
}
