using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CF.MusicCollection
{
    public partial class MainWindow : Window
    {
        public MusicModelApp modelApp = new MusicModelApp();
        public MainWindow()
        {
            InitializeComponent();
            Genre one = new Genre() { Name = "qwe" };
            modelApp.Genres.Add(one);
            modelApp.SaveChanges();
        }

        private void Label_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClickNear.Visibility = Visibility.Hidden;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "*.png|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == true)
                {
                    ImgPlaylists.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                }
                else
                {
                    ClickNear.Visibility = Visibility.Visible;
                }
            }
        }

        private void AddPlaylist_Click(object sender, RoutedEventArgs e)
        {
            bool isEqueal = false;
            foreach (var item in modelApp.Playlists)
            {
                if (item.Name == NameP.Text)
                {
                    modelApp.Playlists.Add(new Playlist() { Name = NameP.Text, ImagePath = ((BitmapImage)ImgPlaylists.Source).UriSource.AbsolutePath });
                    modelApp.Playlists.Remove(item);
                    isEqueal = true;
                }
            }

            if (isEqueal == true)
            {
                modelApp.SaveChanges();
                return;
            }

            modelApp.Playlists.Add(new Playlist() { Name = NameP.Text, ImagePath = ((BitmapImage)ImgPlaylists.Source).UriSource.AbsolutePath });
            modelApp.SaveChanges();

            MessageBox.Show("Editing successful!");

            NameP.Text = null;
            ImgPlaylists.Source = null;
            ClickNear.Visibility = Visibility.Visible;
        }

        private void Label_MouseDoubleClick_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClickNearAlbum.Visibility = Visibility.Hidden;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "*.png|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == true)
                {
                    ImgAlbums.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                }
                else
                {
                    ClickNearAlbum.Visibility = Visibility.Visible;
                }
            }
        }

        private void AddAlbum_Click(object sender, RoutedEventArgs e)
        {
            bool isEqueal = false;
            foreach (var item in modelApp.Albums)
            {
                if (item.Name == NameP.Text)
                {
                    modelApp.Albums.Add(new Album() { Name = NameP.Text, Year = item.Year, ImagePath = ((BitmapImage)ImgAlbums.Source).UriSource.AbsolutePath });
                    modelApp.Albums.Remove(item);
                    isEqueal = true;
                }
            }

            if (isEqueal == true)
            {
                modelApp.SaveChanges();
                return;
            }

            modelApp.Albums.Add(new Album() { Name = NameP.Text, ImagePath = ((BitmapImage)ImgAlbums.Source).UriSource.AbsolutePath });
            modelApp.SaveChanges();

            MessageBox.Show("Editing successful!");

            NameC.Text = null;
            ImgAlbums.Source = null;
            ClickNearAlbum.Visibility = Visibility.Visible;
        }

        private void AddTreck_Click(object sender, RoutedEventArgs e)
        {
            modelApp.Trecks.Add(new Treck() { Name = NameT.Text, Duration = TimeSpan.Parse(NameDuration.Text), AlbumId = int.Parse(AlbumId.Text) });
            modelApp.SaveChanges();
        }
    }
}
