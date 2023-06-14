using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Music_Collection
{
    public class DbInitializer : CreateDatabaseIfNotExists<MusicModelApp>
    {
        protected override void Seed(MusicModelApp context)
        {
            base.Seed(context);

            context.Trecks.Add(new Trecks() { Name = "Nirvana", Duration = TimeSpan.FromMinutes(5) });
            context.Trecks.Add(new Trecks() { Name = "Kolo", Duration = TimeSpan.FromMinutes(3) });
            context.Trecks.Add(new Trecks() { Name = "Top", Duration = TimeSpan.FromMinutes(2) });

            context.Albums.Add(new Albums() { Name = "Nomu", Year = 2001 });
            context.Albums.Add(new Albums() { Name = "Tori", Year = 2020 });
            context.Albums.Add(new Albums() { Name = "Kotu", Year = 2006 });

            context.Artists.Add(new Artists() { Name = "Lor", Surname = "Yoto" });
            context.Artists.Add(new Artists() { Name = "Kot", Surname = "Yot" });
            context.Artists.Add(new Artists() { Name = "Dog", Surname = "Jot" });

            context.Categories.Add(new Categories() { Name = "Solo" });
            context.Categories.Add(new Categories() { Name = "Duo" });
            context.Categories.Add(new Categories() { Name = "Trio" });

            context.Countries.Add(new Countries() { Name = "Ukraine" });
            context.Countries.Add(new Countries() { Name = "England" });
            context.Countries.Add(new Countries() { Name = "USA" });

            context.Playlists.Add(new Playlists() { Name = "One" });
            context.Playlists.Add(new Playlists() { Name = "Two" });
            context.Playlists.Add(new Playlists() { Name = "Three" });

            context.Genres.Add(new Genres() { Name = "Electric" });
            context.Genres.Add(new Genres() { Name = "Metal" });
            context.Genres.Add(new Genres() { Name = "Rock" });

            context.SaveChanges();
        }
    }
}
