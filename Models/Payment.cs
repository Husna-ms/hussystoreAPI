using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HusstoreAPI.Models
{

    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order? Order { get; set; }

    }
}
