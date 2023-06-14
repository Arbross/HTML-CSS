using System;
using System.Data.Entity;

namespace Entity_Framework.Code_First.Migrations
{
    public class DbInitializer : DropCreateDatabaseAlways<MusicModel>
    {
        protected override void Seed(MusicModel context)
        {
            base.Seed(context);

            Trecks one = context.Trecks.Add(new Trecks() { Name = "Nirvana", Duration = TimeSpan.FromMinutes(5), Listening = 50, Rate = 10, TreckText = "dfgdfgdfgdfbvcbdfgdffd" });
            Trecks two = context.Trecks.Add(new Trecks() { Name = "Kolo", Duration = TimeSpan.FromMinutes(3), Listening = 43, Rate = 5000, TreckText = "wetrewtretertrt" });
            Trecks three = context.Trecks.Add(new Trecks() { Name = "Top", Duration = TimeSpan.FromMinutes(2), Listening = 55, Rate = 50, TreckText = "dfgdgfdg" });

            context.Albums.Add(new Albums() { Name = "Nomu", Year = 2001, Rate = 50 });
            context.Albums.Add(new Albums() { Name = "Tori", Year = 2020, Rate = 50 });
            context.Albums.Add(new Albums() { Name = "Kotu", Year = 2006, Rate = 50 });
            context.Albums.Add(new Albums() { Name = "Kolo", Year = 2015, Rate = 500 });

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
