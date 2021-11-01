using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ProductBindingTarget
    {
        [Required]
        public string Name { get; set; }
        [Range(1, 1000)]
        public decimal Price { get; set; }
        [Range(1, long.MaxValue)]
        public long CategoryId { get; set; }
        [Range(1, long.MaxValue)]
        public long SupplierId { get; set; }
        public Product ToProduct() => new Product()
        {
            Name = this.Name,
            Price = this.Price,
            CategoryId = this.CategoryId,
            SupplierId = this.SupplierId
        };
    }
}
