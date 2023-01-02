namespace WebApplication7.ViewModels.Products
{
    public class ProductAddEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }
        public string? Description { get; set; }
        public string? ImageFileName { get; set; }
       
        public int CategoryId { get; set; }
    }
}
