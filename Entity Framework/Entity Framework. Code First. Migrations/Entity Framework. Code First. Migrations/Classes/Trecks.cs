using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Code_First.Migrations
{
    public class Trecks
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        public int Rate { get; set; }
        [MaxLength(2000)]
        public string TreckText { get; set; }
        public int Listening { get; set; }
        public virtual Albums Album { get; set; }
    }
}
