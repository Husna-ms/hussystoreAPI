using HusstoreAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HusstoreAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Address { get; set; }
        [JsonIgnore]
        public List<Order>? Orders { get; set; }
    }
}
