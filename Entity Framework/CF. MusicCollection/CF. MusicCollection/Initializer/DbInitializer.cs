using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.MusicCollection
{
    public class DbInitializer : CreateDatabaseIfNotExists<MusicModelApp>
    {
        protected override void Seed(MusicModelApp context)
        {
            base.Seed(context);

            context.Trecks.Add(new Treck() { Name = "Nirvana", Duration = TimeSpan.FromMinutes(5) });
            context.Trecks.Add(new Treck() { Name = "Kolo", Duration = TimeSpan.FromMinutes(3) });
            context.Trecks.Add(new Treck() { Name = "Top", Duration = TimeSpan.FromMinutes(2) });

            context.Albums.Add(new Album() { Name = "Nomu", Year = 2001 });
            context.Albums.Add(new Album() { Name = "Tori", Year = 2020 });
            context.Albums.Add(new Album() { Name = "Kotu", Year = 2006 });

            context.Artists.Add(new Artist() { Name = "Lor", Surname = "Yoto" });
            context.Artists.Add(new Artist() { Name = "Kot", Surname = "Yot" });
            context.Artists.Add(new Artist() { Name = "Dog", Surname = "Jot" });

            context.Categories.Add(new Category() { Name = "Solo" });
            context.Categories.Add(new Category() { Name = "Duo" });
            context.Categories.Add(new Category() { Name = "Trio" });

            context.Countries.Add(new Country() { Name = "Ukraine" });
            context.Countries.Add(new Country() { Name = "England" });
            context.Countries.Add(new Country() { Name = "USA" });

            context.Playlists.Add(new Playlist() { Name = "One" });
            context.Playlists.Add(new Playlist() { Name = "Two" });
            context.Playlists.Add(new Playlist() { Name = "Three" });

            context.Genres.Add(new Genre() { Name = "Electric" });
            context.Genres.Add(new Genre() { Name = "Metal" });
            context.Genres.Add(new Genre() { Name = "Rock" });

            context.SaveChanges();
        }
    }
}
