using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Shop
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Address { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public int? ParkingArea { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
