using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Worker
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        [Required, MaxLength(30)]
        public string Email { get; set; }

        [Required, MaxLength(10)]
        public string PhoneNumber { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }

        public virtual Position Position { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
