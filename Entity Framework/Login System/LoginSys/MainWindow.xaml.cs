using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginSys
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    /*
        CREATE DATABASE UserLoginDB

        USE UserLoginDB
        
        GO
        
        CREATE TABLE Users
        (
        	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        	[Login] NVARCHAR(MAX) NOT NULL CHECK([Login] <> ''),
        	[Password] NVARCHAR(MAX) NOT NULL CHECK([Password] <> ''),
        	[Adress] NVARCHAR(MAX) NOT NULL CHECK([Adress] <> ''),
        	[Telephone] NVARCHAR(10) NOT NULL CHECK([Telephone] <> '')
        )
        
        GO
        
        CREATE TABLE Rooms
        (
        	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        	[Room] NVARCHAR(MAX) NOT NULL CHECK([Room] <> ''),
        	[Adress] NVARCHAR(MAX) NOT NULL CHECK([Adress] <> ''),
        	[Square] NVARCHAR(MAX) NOT NULL CHECK([Square] <> ''),
        	[City] NVARCHAR(MAX) NOT NULL CHECK([City] <> ''),
        	[Duration] DATE NOT NULL CHECK([Duration] >= GetDate()),
        	[IsTaken] BIT NOT NULL DEFAULT(0)
        )
        
        GO
        
        CREATE TABLE Rents
        (
        	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        	[UserId] INT NOT NULL REFERENCES Users(Id),
        	[RoomId] INT NOT NULL REFERENCES Rooms(Id)
        )
        
        GO
        
        CREATE TABLE PastRents
        (
        	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        	[UserId] INT NOT NULL REFERENCES Users(Id),
        	[RoomId] INT NOT NULL REFERENCES Rooms(Id)
        )
        
    */
    public partial class MainWindow : Window
    {
        public LoginAndRegistrationContext dataContext = new LoginAndRegistrationContext();
        public MainWindow()
        {
            InitializeComponent();
            btnLogOut.IsEnabled = false;
            GetListAvailableOwn.IsEnabled = false;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            dataContext.Login(LoginN.Text, LoginAndRegistrationContext.ComputeSha256Hash(PasswordN.Text));
            if (dataContext.IsLogin == true)
            {
                btnLogin.IsEnabled = false;
                GetListAvailableOwn.IsEnabled = true;
                btnLogOut.IsEnabled = true;
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            dataContext.Register(Login.Text, Password.Text, Address.Text, Telephone.Text);
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            dataContext.LogOut();
            if (dataContext.IsLogin == false)
            {
                btnLogOut.IsEnabled = false;
                GetListAvailableOwn.IsEnabled = false;
                btnLogin.IsEnabled = true;
            }
        }

        private void GetListAvailable_Click(object sender, RoutedEventArgs e)
        {
            RentsService.ShowFree(dataContext.entities, NeedSquare.Text, NeedDuration.Text, ref listBox);
        }

        private void GetListAvailableOwn_Click(object sender, RoutedEventArgs e)
        {
            RentsService.ShowOwn(dataContext.entities, dataContext, ref listBox);
        }

        private void DeleteActiveOwn_Click(object sender, RoutedEventArgs e)
        {
            RentsService.DeleteActive(dataContext.entities, dataContext, listBox.SelectedItem as Room, ref listBox);
        }

        private void btnPastOwn_Click(object sender, RoutedEventArgs e)
        {
            RentsService.ShowPastOwn(dataContext.entities, dataContext, ref listBox);
        }
    }
}
