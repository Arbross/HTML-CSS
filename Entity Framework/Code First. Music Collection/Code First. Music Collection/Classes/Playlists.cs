using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code_First.Music_Collection
{
    public class Playlists
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<Trecks> Trecks { get; set; }
        public virtual Categories Categoria { get; set; }
    }
}
