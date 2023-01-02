using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication7.Data.Entities
{
    public class Cart:BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public DateTime Added { get; set; }
        
        public string UserId { get; set; }
    }
}
