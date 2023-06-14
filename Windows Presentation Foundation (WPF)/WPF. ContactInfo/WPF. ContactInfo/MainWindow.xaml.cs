using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.IO;

namespace WPF._ContactInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Numbers> numbers;
        public MainWindow()
        {
            InitializeComponent();
            numbers = new ObservableCollection<Numbers>();
            ListNames.ItemsSource = numbers;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            numbers.Add(new Numbers(Name.Text, Surname.Text, Phone.Text, uint.Parse(Age.Text), nCity.Text));
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (ListNames.SelectedItem != null)
            {
                numbers.RemoveAt(ListNames.SelectedIndex);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (ListNames.SelectedItem != null)
            {
                numbers[ListNames.SelectedIndex] = new Numbers(Name.Text, Surname.Text, Phone.Text, uint.Parse(Age.Text), nCity.Text);
            }
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Photos.Visibility = Visibility.Visible;
            List<string> paths = new List<string>();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\victor\Desktop");

            foreach (var fi in di.GetFiles())
            {
                paths.Add(fi.FullName);
            }

            Photos.ItemsSource = paths;
        }

        private void Photos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Photo.Source = Photos.SelectedItem;
        }
    }
    public class Numbers : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private string surname;
        private string phone;
        private string city;
        private uint age;
        public string FullName => Name + " " + Surname; 
        public Numbers(string name, string surname, string phone, uint age, string city)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Age = age;
            City = city;
        }
        public string Name
        {
            get => name;
            set 
            { 
                name = value;
                Update();
            }
        }
        public string Surname
        {
            get => surname;
            set 
            { 
                surname = value;
                Update();
            }
        }
        public string Phone
        {
            get => phone;
            set 
            { 
                phone = value;
                Update();
            }
        }
        public uint Age
        {
            get => age;
            set 
            {
                age = value;
                Update();
            }
        }
        public string City
        {
            get => city;
            set
            {
                city = value;
                Update();
            }
        }
        private void Update()
        {
            NotifyPropertyChanged(nameof(Name));
            NotifyPropertyChanged(nameof(Surname));
            NotifyPropertyChanged(nameof(Phone));
            NotifyPropertyChanged(nameof(Age));
            NotifyPropertyChanged(nameof(City));
        }
        public override string ToString()
        {
            return $"Name : {Name}, Surname : {Surname}, Phone : {Phone}, Age : {Age}, City : {City}";
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
