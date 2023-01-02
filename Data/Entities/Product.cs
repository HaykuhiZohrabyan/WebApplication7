using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication7.Data.Entities
{
    public class Product:BaseEntity
    {
       
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }
        public string? Description { get; set; }
        public string? ImageFileName { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        //Navigation Property
        public Category Category { get; set; }
    }
}
