using WebApplication7.ViewModels.Products;
namespace WebApplication7.Services.Interfaces
{
    public interface IProductService
    {
        public void Add(ProductAddEditViewModel model);
        public List<ProductListViewModel> GetAllByCategory(int CategoryId);
    }
}
