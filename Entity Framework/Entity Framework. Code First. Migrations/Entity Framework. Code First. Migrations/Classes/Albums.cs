using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Code_First.Migrations
{
    public class Albums
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rate { get; set; }
        public virtual Artists Artist { get; set; } 
        public virtual Genres Genre { get; set; }
        public virtual ICollection<Trecks> Trecks { get; set; }
    }
}
