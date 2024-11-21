using HusstoreAPI.Models;
using HusstoreAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HusstoreAPI.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [JsonIgnore]
        public Customer? Customer { get; set; }
        [JsonIgnore]
        public List<Product>? Products { get; set; }
        [JsonIgnore]
        public List<Payment>? Payments { get; set; }
    }
}
