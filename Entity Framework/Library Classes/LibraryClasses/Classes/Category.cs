using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Category
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
