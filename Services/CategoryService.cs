using WebApplication7.Services.Interfaces;
using WebApplication7.ViewModels.Categories;
using WebApplication7.Data;
using WebApplication7.Data.Entities;
using WebApplication7.ViewModels;

namespace WebApplication7.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        public CategoryService(DataContext dataContext)
        {
            _context = dataContext;
        }
        public void Add(CategoryAddEdit model)
        {
            bool isExist = _context.Categories.Any(c => c.Name == model.Name);
            if(isExist)
            {
                throw new Exception("Category exist");
            }
            Category category = new Category
            {
                Name = model.Name,
                
            
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public List<CategoryListViewModel> GetAll()
        {
            var data = _context.Categories.Select(c => new CategoryListViewModel
            {
                CategoryId =  c.Id,
                CategoryName = c.Name,
                ProductCount = c.Products.Count()
            }).ToList();
            return data;
        }

        public List<DropDownViewModel> GetListForDropdown()
        {
            var data = _context.Categories.Select(c => new DropDownViewModel
            {
                Text=c.Name,
                Value=c.Id
            }).ToList();
            return data;
        }

        public bool IsExist(string categoryName)
        {
            return _context.Categories.Any(c => c.Name.ToLower() == categoryName.ToLower());
        }
    }
}
