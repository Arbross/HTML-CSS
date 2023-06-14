using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }

        public virtual ICollection<Shop> Shops { get; set; }
        public virtual Category Category { get; set; }
    }
}
