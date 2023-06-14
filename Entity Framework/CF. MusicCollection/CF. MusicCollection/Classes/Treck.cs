using System;
using System.ComponentModel.DataAnnotations;

namespace CF.MusicCollection
{
    public partial class Treck
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }
        public int? AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
