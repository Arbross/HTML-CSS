using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Code_First.Music_Collection
{
    public partial class MainWindow : Window
    {
        public MusicModelApp modelApp = new MusicModelApp();
        public MainWindow()
        {
            InitializeComponent();
            Genres one = new Genres() { Name = "qwe"};
            //modelApp.Genres.Add(one);
            //modelApp.SaveChanges();
        }

        private void Label_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
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
            }
        }

        private void AddPlaylist_Click(object sender, RoutedEventArgs e)
        {
            modelApp.Playlists.Add(new Playlists() { Name = NameP.Text, ImagePath = ((BitmapImage)ImgPlaylists.Source).UriSource.AbsolutePath });
        }
    }
}
