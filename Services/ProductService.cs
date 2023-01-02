using WebApplication7.Services.Interfaces;
using WebApplication7.ViewModels.Products;
using WebApplication7.Data;
using WebApplication7.Data.Entities;

namespace WebApplication7.Services
{
    public class ProductService:IProductService
    {
        private readonly DataContext _context;

        
        public ProductService(DataContext dataContext)
        {
            _context = dataContext;
        }
        public void Add(ProductAddEditViewModel model)
        {
            var entity = new Product { 
            Description = model.Description,
            Discount = model.Discount,
            CategoryId= model.CategoryId,
            Name=model.Name,
            Price=model.Price
            
            };
          
            _context.Products.Add(entity);
            _context.SaveChanges();

           
        }

        public List<ProductListViewModel> GetAllByCategory(int CategoryId)
        {
            var data = _context.Products
                 .Where(c => c.CategoryId == CategoryId)
                 .Select(c=> new ProductListViewModel
                 {
                     Discount = c.Discount,
                     Id = c.Id,
                     Name= c.Name,
                     Price =c.Price
                 }).ToList();
            return data;
        }
    }
}
