namespace WebApplication7.ViewModels.Products
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }
        public int NewPrice => Price - Price / 100 * Discount.GetValueOrDefault();
        public string PriceCssClassName
        {
            get
            {
                return Discount > 0 ? "new-price" : null;
            }
        }
    }
}
