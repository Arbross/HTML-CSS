using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.MusicCollection
{
    public partial class Playlist
    {
        public Playlist()
        {
            Trecks = new HashSet<Treck>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Treck> Trecks { get; set; }
    }
}
