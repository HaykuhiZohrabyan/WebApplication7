using WebApplication7.ViewModels.Categories;
using WebApplication7.ViewModels;
namespace WebApplication7.Services.Interfaces
{
    public interface ICategoryService
    {
        void Add(CategoryAddEdit model);
        bool IsExist(string categoryName);
        List<DropDownViewModel> GetListForDropdown();
        List<CategoryListViewModel> GetAll();
    }
}
