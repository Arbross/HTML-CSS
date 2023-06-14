using LibraryClasses;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Windows;


namespace UI_App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShopsCFModel model = new ShopsCFModel();
        public MainWindow()
        {
            InitializeComponent();            

            One.ItemsSource = model.Categories.ToList();
            Two.ItemsSource = model.Cities.ToList();
            Three.ItemsSource = model.Countries.ToList();
            Four.ItemsSource = model.Positions.ToList();
            Five.ItemsSource = model.Products.ToList();
            Six.ItemsSource = model.Products.ToList();
            Seven.ItemsSource = model.Workers.ToList();
        }
    }
}
