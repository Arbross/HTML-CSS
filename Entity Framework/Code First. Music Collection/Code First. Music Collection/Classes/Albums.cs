using System.ComponentModel.DataAnnotations;
using System.Windows.Controls;

namespace Code_First.Music_Collection
{
    public class Albums
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        public Image Image { get; set; }
        public int Year { get; set; }
        public virtual Artists Artist { get; set; } 
        public virtual Genres Genre { get; set; } 
    }
}
