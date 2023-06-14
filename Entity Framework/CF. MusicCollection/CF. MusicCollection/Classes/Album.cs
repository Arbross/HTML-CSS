using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CF.MusicCollection
{
    public partial class Album
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        public int Year { get; set; }
        public string ImagePath { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }

    }
}
