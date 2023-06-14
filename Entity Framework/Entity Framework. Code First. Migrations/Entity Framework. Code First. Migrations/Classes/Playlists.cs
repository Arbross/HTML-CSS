using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Code_First.Migrations
{
    public class Playlists
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        // public Image Image { get; set; }
        public virtual ICollection<Trecks> Trecks { get; set; }
        public virtual Categories Categoria { get; set; }
    }
}
