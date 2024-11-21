using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HusstoreAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int Stock { get; set; }
        [JsonIgnore]
        public List<Order>? Orders { get; set; }
    }
}
