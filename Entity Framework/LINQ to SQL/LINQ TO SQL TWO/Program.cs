using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TO_SQL_TWO
{
    public class MusicCollection_DB_Task_Two
    {
        private MusicCollectionDBDataContext dataContext = new MusicCollectionDBDataContext();
        public IEnumerable<MusicDiscs> GetAllMusicDisksByACurrentYear(int music_disk_year)
        {
            return dataContext.MusicDiscs.Where(x => x.ReleaseDate.Year == music_disk_year);
        }
        public IEnumerable<MusicDiscs> GetAllInfoAboutTheMusicDisksWithSameAlbumNameButWithTheDifferentMaker()
        {
            return dataContext.MusicDiscs.Where(x => x.Performers.Name != dataContext.MusicDiscs.FirstOrDefault(c => c.Performers.Name != x.Performers.Name).Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MusicCollection_DB_Task_Two mc = new MusicCollection_DB_Task_Two();
            foreach (MusicDiscs item in mc.GetAllMusicDisksByACurrentYear(2018))
            {
                Console.WriteLine($"{item.Id}, {item.Name}, {item.PerformerId}, {item.PublisherId}, {item.ReleaseDate}, {item.StyleId}");
            }
            Console.WriteLine();
            foreach (MusicDiscs item in mc.GetAllInfoAboutTheMusicDisksWithSameAlbumNameButWithTheDifferentMaker())
            {
                Console.WriteLine($"{item.Id}, {item.Name}, {item.PerformerId}, {item.PublisherId}, {item.ReleaseDate}, {item.StyleId}");
            }
        }
    }
}
