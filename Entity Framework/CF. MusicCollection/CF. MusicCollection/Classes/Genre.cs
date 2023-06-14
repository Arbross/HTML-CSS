using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CF.MusicCollection
{
    public partial class Genre
    {
        public Genre()
        {
            Albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
