using Microsoft.AspNetCore.Mvc;
using WebApplication7.Data;
using WebApplication7.ViewModels.Products;
using Microsoft.AspNetCore.Hosting;
namespace WebApplication7.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {

            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _categoryService.GetListForDropdown();
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductAddEditViewModel model)
        {
            _productService.Add(model);
            return Redirect("/");
        }
    }
}
