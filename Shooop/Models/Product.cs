using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shooop.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }

        [Required]
        [DisplayName("product name")]
        public string productName { get; set; }
        public string description { get; set; }
        [Required]
        public decimal price { get; set; }
        public int stock { get; set; }

        public string image { get; set; }
    }
}
