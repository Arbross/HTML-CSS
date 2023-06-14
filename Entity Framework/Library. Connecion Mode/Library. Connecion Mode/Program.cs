using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library.Connecion_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            string conn = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            Console.WriteLine("1 - New user adding");
            Console.WriteLine("2 - Get count of registered users");
            Console.WriteLine("3 - List of users in a debt");
            Console.WriteLine("4 - List of authors of a current book");
            Console.WriteLine("5 - List of free books in a current moment");
            Console.WriteLine("6 - List of free books in a current user");
            Console.WriteLine("7 - Clear debt of all users");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1": 
                    {
                        Console.WriteLine("Enter name : "); string name = Console.ReadLine();
                        Console.WriteLine("Enter pages : "); string pages = Console.ReadLine();
                        string cmdText = $"INSERT INTO Books (Name, Pages) VALUES ('{name}', {Convert.ToInt32(pages)});";

                        SqlCommand command = new SqlCommand(cmdText, connection);

                        command.ExecuteScalar();
                        Console.WriteLine("The row successfuly added!");
                    }
                    break;
                case "2":
                    {
                        string cmdText = $"SELECT COUNT(Id) AS 'Registered Users Count' FROM Users";

                        SqlCommand command = new SqlCommand(cmdText, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        Console.OutputEncoding = Encoding.UTF8;

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine("\n------------------------------");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i] + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case "3":
                    {
                        string cmdText = $"SELECT COUNT(Id) AS 'Registered Users Count' FROM Users WHERE IsInADebt = 1";

                        SqlCommand command = new SqlCommand(cmdText, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        Console.OutputEncoding = Encoding.UTF8;

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine("\n------------------------------");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i] + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("Enter book name : "); string book_name = Console.ReadLine();
                        string cmdText = $"SELECT * FROM Authors AS A JOIN AuthorBookConn AS ABC ON A.Id = ABC.AuthorId JOIN Book AS B ON B.Id = ABC.BookId WHERE '{book_name}' = B.Name";

                        SqlCommand command = new SqlCommand(cmdText, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        Console.OutputEncoding = Encoding.UTF8;

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine("\n------------------------------");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i] + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case "5":
                    {
                        string cmdText = $"SELECT * FROM Books WHERE Books.IsFree = 1";

                        SqlCommand command = new SqlCommand(cmdText, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        Console.OutputEncoding = Encoding.UTF8;

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine("\n------------------------------");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i] + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case "6":
                    {
                        Console.WriteLine("Enter user name : "); string user_name = Console.ReadLine();
                        string cmdText = $"SELECT B.Name FROM Books AS B JOIN UserBookConn AS UBC ON UBC.BookId = B.Id JOIN Users AS U ON UBC.UserId = U.Id WHERE '{user_name}' = U.Name";

                        SqlCommand command = new SqlCommand(cmdText, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        Console.OutputEncoding = Encoding.UTF8;

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine("\n-------------");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i] + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case "7":
                    {
                        string cmdText = $"UPDATE Users SET IsInADebt = 0 WHERE IsInADebt = 1";

                        SqlCommand command = new SqlCommand(cmdText, connection);

                        command.ExecuteScalar();
                        Console.WriteLine("The row successfuly updated!");
                    }
                    break;
                default:
                    break;
            }
            connection.Close();
        }
    }
}

/*CREATE DATABASE LibraryCONMODE

USE LibraryCONMODE

CREATE TABLE Authors
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(25) NOT NULL CHECK([Name] <> ''),
	[Surname] NVARCHAR(25) NOT NULL CHECK([Surname] <> '')
)

GO

CREATE TABLE Books
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(25) NOT NULL CHECK([Name] <> ''),
	[Pages] int NOT NULL DEFAULT(1),
	[IsFree] BIT NOT NULL DEFAULT(1)
)

GO

CREATE TABLE Users
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(25) NOT NULL CHECK([Name] <> ''),
	[Surname] NVARCHAR(25) NOT NULL CHECK([Surname] <> ''),
	[IsInADebt] BIT NOT NULL DEFAULT(0)
)

GO

CREATE TABLE UserBookConn
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[BookId] INT NOT NULL REFERENCES Books(Id),
	[UserId] INT NOT NULL REFERENCES Users(Id)
)

GO

CREATE TABLE AuthorBookConn
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[BookId] INT NOT NULL REFERENCES Books(Id),
	[AuthorId] INT NOT NULL REFERENCES Authors(Id)
)

insert into Authors (Name, Surname) values ('Cort', 'Yakubovics');
insert into Authors (Name, Surname) values ('Meriel', 'Dayly');
insert into Authors (Name, Surname) values ('Antonius', 'Simenel');
insert into Authors (Name, Surname) values ('Aeriela', 'Teulier');
insert into Authors (Name, Surname) values ('Berny', 'Kornacki');
insert into Authors (Name, Surname) values ('Ariel', 'Haithwaite');
insert into Authors (Name, Surname) values ('Ave', 'Guerreiro');
insert into Authors (Name, Surname) values ('Gardner', 'Waldram');
insert into Authors (Name, Surname) values ('Rivi', 'Bayliss');
insert into Authors (Name, Surname) values ('Abbe', 'Place');
insert into Authors (Name, Surname) values ('Teressa', 'Wescott');
insert into Authors (Name, Surname) values ('Krissy', 'Delong');
insert into Authors (Name, Surname) values ('Ric', 'Longthorn');
insert into Authors (Name, Surname) values ('Alina', 'Quig');
insert into Authors (Name, Surname) values ('Leanna', 'Connah');
insert into Authors (Name, Surname) values ('Sallyanne', 'Braybrooks');
insert into Authors (Name, Surname) values ('Hettie', 'Obington');
insert into Authors (Name, Surname) values ('Katee', 'Raynham');
insert into Authors (Name, Surname) values ('Emelen', 'Palffy');
insert into Authors (Name, Surname) values ('Abbe', 'Lammie');
insert into Authors (Name, Surname) values ('Bent', 'Averay');
insert into Authors (Name, Surname) values ('Gibbie', 'Moyne');
insert into Authors (Name, Surname) values ('Christian', 'Delagua');
insert into Authors (Name, Surname) values ('Cristina', 'Crut');
insert into Authors (Name, Surname) values ('Kimberley', 'Woonton');
insert into Authors (Name, Surname) values ('Cosme', 'Croxford');
insert into Authors (Name, Surname) values ('Godfry', 'Craiker');
insert into Authors (Name, Surname) values ('Gare', 'Albery');
insert into Authors (Name, Surname) values ('Renard', 'Hause');
insert into Authors (Name, Surname) values ('Man', 'Mauchline');
insert into Authors (Name, Surname) values ('Leese', 'Hindhaugh');
insert into Authors (Name, Surname) values ('Cam', 'Tansly');
insert into Authors (Name, Surname) values ('Obed', 'Saywood');
insert into Authors (Name, Surname) values ('Philipa', 'Giacomazzo');
insert into Authors (Name, Surname) values ('Francisca', 'Clemon');
insert into Authors (Name, Surname) values ('Joceline', 'Fisby');
insert into Authors (Name, Surname) values ('Luce', 'Shillington');
insert into Authors (Name, Surname) values ('Egbert', 'Oughton');
insert into Authors (Name, Surname) values ('Jorrie', 'Turfrey');
insert into Authors (Name, Surname) values ('Francklyn', 'Chaimson');
insert into Authors (Name, Surname) values ('Nickey', 'Yellowlee');
insert into Authors (Name, Surname) values ('Spense', 'Insole');
insert into Authors (Name, Surname) values ('Bil', 'Heckner');
insert into Authors (Name, Surname) values ('Anetta', 'Mattusov');
insert into Authors (Name, Surname) values ('Dukie', 'Waith');
insert into Authors (Name, Surname) values ('Gerri', 'Golsthorp');
insert into Authors (Name, Surname) values ('Doralin', 'Fursland');
insert into Authors (Name, Surname) values ('Davine', 'Luckey');
insert into Authors (Name, Surname) values ('Darya', 'Sparshutt');
insert into Authors (Name, Surname) values ('Lowell', 'Maghull');
insert into Authors (Name, Surname) values ('Annamaria', 'Charpling');
insert into Authors (Name, Surname) values ('Carlyle', 'Eke');
insert into Authors (Name, Surname) values ('Laura', 'Medeway');
insert into Authors (Name, Surname) values ('Eziechiele', 'Balshaw');
insert into Authors (Name, Surname) values ('Morganica', 'Highway');
insert into Authors (Name, Surname) values ('Joby', 'Roddick');
insert into Authors (Name, Surname) values ('Kerwinn', 'Andreassen');
insert into Authors (Name, Surname) values ('Cherish', 'Blenkinsopp');
insert into Authors (Name, Surname) values ('Laney', 'Overington');
insert into Authors (Name, Surname) values ('Palm', 'Troop');
insert into Authors (Name, Surname) values ('Constancy', 'Flores');
insert into Authors (Name, Surname) values ('Nell', 'Nower');
insert into Authors (Name, Surname) values ('Liuka', 'Chsteney');
insert into Authors (Name, Surname) values ('Kristel', 'Findon');
insert into Authors (Name, Surname) values ('Frasco', 'Bird');
insert into Authors (Name, Surname) values ('Lanita', 'Trevaskis');
insert into Authors (Name, Surname) values ('Nelson', 'Rudgerd');
insert into Authors (Name, Surname) values ('Jordon', 'Skillett');
insert into Authors (Name, Surname) values ('Frayda', 'Phipps');
insert into Authors (Name, Surname) values ('Emelina', 'Beaumont');
insert into Authors (Name, Surname) values ('Annette', 'Caudwell');
insert into Authors (Name, Surname) values ('Carling', 'Leyband');
insert into Authors (Name, Surname) values ('Ambros', 'Hellens');
insert into Authors (Name, Surname) values ('Ekaterina', 'Yole');
insert into Authors (Name, Surname) values ('Godfrey', 'Aldin');
insert into Authors (Name, Surname) values ('Bailie', 'Illes');
insert into Authors (Name, Surname) values ('Jeremias', 'Montier');
insert into Authors (Name, Surname) values ('Trude', 'Tuffs');
insert into Authors (Name, Surname) values ('Karel', 'Ronan');
insert into Authors (Name, Surname) values ('Kirsten', 'Scraggs');
insert into Authors (Name, Surname) values ('Milo', 'Unsworth');
insert into Authors (Name, Surname) values ('Abe', 'Patershall');
insert into Authors (Name, Surname) values ('Liam', 'Gimlet');
insert into Authors (Name, Surname) values ('Bell', 'Venart');
insert into Authors (Name, Surname) values ('Vite', 'Brunner');
insert into Authors (Name, Surname) values ('Guss', 'McLagan');
insert into Authors (Name, Surname) values ('Reinwald', 'Raven');
insert into Authors (Name, Surname) values ('Wally', 'Van der Merwe');
insert into Authors (Name, Surname) values ('Halli', 'Nowakowska');
insert into Authors (Name, Surname) values ('Godwin', 'Cust');
insert into Authors (Name, Surname) values ('Kim', 'Dunderdale');
insert into Authors (Name, Surname) values ('Anna-diana', 'Plank');
insert into Authors (Name, Surname) values ('Benyamin', 'Garrit');
insert into Authors (Name, Surname) values ('Marmaduke', 'Jenkison');
insert into Authors (Name, Surname) values ('Nels', 'Bonny');
insert into Authors (Name, Surname) values ('Heddie', 'Chace');
insert into Authors (Name, Surname) values ('Lidia', 'Akroyd');
insert into Authors (Name, Surname) values ('Terrijo', 'Foyster');
insert into Authors (Name, Surname) values ('Ahmad', 'Cavet');
insert into Authors (Name, Surname) values ('Leanna', 'Wapple');

insert into Books (Name, Pages, IsFree) values ('Gretta', 2523, 1);
insert into Books (Name, Pages, IsFree) values ('Ingaberg', 4742, 1);
insert into Books (Name, Pages, IsFree) values ('Merrel', 7618, 1);
insert into Books (Name, Pages, IsFree) values ('Tersina', 2075, 1);
insert into Books (Name, Pages, IsFree) values ('Polly', 4881, 0);
insert into Books (Name, Pages, IsFree) values ('Lynne', 8292, 1);
insert into Books (Name, Pages, IsFree) values ('Erl', 6376, 1);
insert into Books (Name, Pages, IsFree) values ('Kalinda', 4482, 1);
insert into Books (Name, Pages, IsFree) values ('Algernon', 1987, 1);
insert into Books (Name, Pages, IsFree) values ('Alfreda', 1176, 0);
insert into Books (Name, Pages, IsFree) values ('Zollie', 6882, 0);
insert into Books (Name, Pages, IsFree) values ('Nil', 7406, 0);
insert into Books (Name, Pages, IsFree) values ('Ragnar', 2548, 0);
insert into Books (Name, Pages, IsFree) values ('Cathee', 3601, 0);
insert into Books (Name, Pages, IsFree) values ('Helge', 5765, 1);
insert into Books (Name, Pages, IsFree) values ('Timmie', 6477, 0);
insert into Books (Name, Pages, IsFree) values ('Willabella', 6221, 1);
insert into Books (Name, Pages, IsFree) values ('Wynny', 6134, 0);
insert into Books (Name, Pages, IsFree) values ('Kaitlyn', 634, 1);
insert into Books (Name, Pages, IsFree) values ('Giacobo', 336, 0);
insert into Books (Name, Pages, IsFree) values ('Lombard', 6695, 0);
insert into Books (Name, Pages, IsFree) values ('Sigismond', 882, 1);
insert into Books (Name, Pages, IsFree) values ('Kenton', 8332, 0);
insert into Books (Name, Pages, IsFree) values ('Kimberley', 1808, 0);
insert into Books (Name, Pages, IsFree) values ('Dennison', 6486, 0);
insert into Books (Name, Pages, IsFree) values ('Kamilah', 1961, 1);
insert into Books (Name, Pages, IsFree) values ('Sheryl', 1230, 0);
insert into Books (Name, Pages, IsFree) values ('Glynis', 5965, 1);
insert into Books (Name, Pages, IsFree) values ('Cordie', 8757, 0);
insert into Books (Name, Pages, IsFree) values ('Kristo', 9267, 0);
insert into Books (Name, Pages, IsFree) values ('Alex', 3005, 0);
insert into Books (Name, Pages, IsFree) values ('Royce', 6044, 0);
insert into Books (Name, Pages, IsFree) values ('Nadine', 127, 1);
insert into Books (Name, Pages, IsFree) values ('Kienan', 4090, 0);
insert into Books (Name, Pages, IsFree) values ('Casi', 4472, 1);
insert into Books (Name, Pages, IsFree) values ('Stephani', 1354, 0);
insert into Books (Name, Pages, IsFree) values ('Fairfax', 5204, 1);
insert into Books (Name, Pages, IsFree) values ('Eydie', 7749, 0);
insert into Books (Name, Pages, IsFree) values ('Con', 3390, 1);
insert into Books (Name, Pages, IsFree) values ('Matthieu', 8743, 1);
insert into Books (Name, Pages, IsFree) values ('Caron', 6876, 0);
insert into Books (Name, Pages, IsFree) values ('Livy', 9316, 0);
insert into Books (Name, Pages, IsFree) values ('Benni', 7512, 0);
insert into Books (Name, Pages, IsFree) values ('Dotty', 724, 0);
insert into Books (Name, Pages, IsFree) values ('Henryetta', 6926, 1);
insert into Books (Name, Pages, IsFree) values ('Lanae', 3509, 0);
insert into Books (Name, Pages, IsFree) values ('Claudius', 4751, 0);
insert into Books (Name, Pages, IsFree) values ('Lusa', 3721, 0);
insert into Books (Name, Pages, IsFree) values ('Mayne', 8203, 0);
insert into Books (Name, Pages, IsFree) values ('Phillipe', 5772, 0);
insert into Books (Name, Pages, IsFree) values ('Harv', 4314, 0);
insert into Books (Name, Pages, IsFree) values ('Valencia', 5037, 0);
insert into Books (Name, Pages, IsFree) values ('Larry', 9379, 0);
insert into Books (Name, Pages, IsFree) values ('Christi', 2021, 1);
insert into Books (Name, Pages, IsFree) values ('Aldric', 9552, 0);
insert into Books (Name, Pages, IsFree) values ('Feodora', 8176, 1);
insert into Books (Name, Pages, IsFree) values ('Cleve', 9819, 1);
insert into Books (Name, Pages, IsFree) values ('Ladonna', 7917, 0);
insert into Books (Name, Pages, IsFree) values ('Tabitha', 5023, 0);
insert into Books (Name, Pages, IsFree) values ('Merrie', 4283, 1);
insert into Books (Name, Pages, IsFree) values ('Asher', 8967, 0);
insert into Books (Name, Pages, IsFree) values ('Teodorico', 7064, 0);
insert into Books (Name, Pages, IsFree) values ('Phebe', 747, 0);
insert into Books (Name, Pages, IsFree) values ('Kirsteni', 9884, 1);
insert into Books (Name, Pages, IsFree) values ('Lilith', 7950, 1);
insert into Books (Name, Pages, IsFree) values ('Ced', 3014, 0);
insert into Books (Name, Pages, IsFree) values ('Lemmy', 1821, 1);
insert into Books (Name, Pages, IsFree) values ('Beryle', 3050, 1);
insert into Books (Name, Pages, IsFree) values ('Rene', 9980, 1);
insert into Books (Name, Pages, IsFree) values ('Mack', 959, 0);
insert into Books (Name, Pages, IsFree) values ('Avrom', 5597, 0);
insert into Books (Name, Pages, IsFree) values ('Taffy', 7440, 1);
insert into Books (Name, Pages, IsFree) values ('Thedrick', 6470, 0);
insert into Books (Name, Pages, IsFree) values ('Gregor', 6678, 1);
insert into Books (Name, Pages, IsFree) values ('Murry', 1661, 1);
insert into Books (Name, Pages, IsFree) values ('Rosaleen', 373, 0);
insert into Books (Name, Pages, IsFree) values ('Terese', 7674, 0);
insert into Books (Name, Pages, IsFree) values ('Aindrea', 6790, 1);
insert into Books (Name, Pages, IsFree) values ('Rachele', 3624, 1);
insert into Books (Name, Pages, IsFree) values ('Noel', 3452, 1);
insert into Books (Name, Pages, IsFree) values ('Douglass', 1093, 1);
insert into Books (Name, Pages, IsFree) values ('Tabatha', 351, 0);
insert into Books (Name, Pages, IsFree) values ('Rodolph', 3728, 0);
insert into Books (Name, Pages, IsFree) values ('Anica', 2311, 1);
insert into Books (Name, Pages, IsFree) values ('Emmalynne', 5224, 0);
insert into Books (Name, Pages, IsFree) values ('Arlyn', 3586, 0);
insert into Books (Name, Pages, IsFree) values ('Debbie', 1745, 0);
insert into Books (Name, Pages, IsFree) values ('Fifi', 4286, 0);
insert into Books (Name, Pages, IsFree) values ('Godart', 755, 1);
insert into Books (Name, Pages, IsFree) values ('Odey', 7142, 1);
insert into Books (Name, Pages, IsFree) values ('Ann', 7533, 1);
insert into Books (Name, Pages, IsFree) values ('Carly', 3652, 0);
insert into Books (Name, Pages, IsFree) values ('Abramo', 2613, 1);
insert into Books (Name, Pages, IsFree) values ('Adriana', 8138, 0);
insert into Books (Name, Pages, IsFree) values ('Foss', 1862, 0);
insert into Books (Name, Pages, IsFree) values ('Ash', 5251, 1);
insert into Books (Name, Pages, IsFree) values ('Elka', 7207, 1);
insert into Books (Name, Pages, IsFree) values ('Harriette', 7165, 0);
insert into Books (Name, Pages, IsFree) values ('Marietta', 7977, 0);
insert into Books (Name, Pages, IsFree) values ('Fredric', 1827, 1);

insert into Users (Name, Surname, IsInADebt) values ('Tabina', 'Keinrat', 0);
insert into Users (Name, Surname, IsInADebt) values ('Ike', 'Eslemont', 1);
insert into Users (Name, Surname, IsInADebt) values ('Nicki', 'Flippelli', 1);
insert into Users (Name, Surname, IsInADebt) values ('Esmaria', 'Veness', 0);
insert into Users (Name, Surname, IsInADebt) values ('Mattie', 'Glasscott', 0);
insert into Users (Name, Surname, IsInADebt) values ('Toddy', 'Davydoch', 0);
insert into Users (Name, Surname, IsInADebt) values ('Ilene', 'Radolf', 1);
insert into Users (Name, Surname, IsInADebt) values ('Andriana', 'Gibbens', 1);
insert into Users (Name, Surname, IsInADebt) values ('Audra', 'Cleworth', 0);
insert into Users (Name, Surname, IsInADebt) values ('Gasper', 'Ruecastle', 0);
insert into Users (Name, Surname, IsInADebt) values ('Dolores', 'Eddie', 0);
insert into Users (Name, Surname, IsInADebt) values ('Sofie', 'Hazlewood', 1);
insert into Users (Name, Surname, IsInADebt) values ('Emmery', 'Peacop', 0);
insert into Users (Name, Surname, IsInADebt) values ('Shaun', 'Rowles', 0);
insert into Users (Name, Surname, IsInADebt) values ('Park', 'Varley', 1);
insert into Users (Name, Surname, IsInADebt) values ('Reinhold', 'Haywood', 1);
insert into Users (Name, Surname, IsInADebt) values ('Cassy', 'Macrow', 1);
insert into Users (Name, Surname, IsInADebt) values ('Yvonne', 'Rucklesse', 0);
insert into Users (Name, Surname, IsInADebt) values ('Meredith', 'Pilbury', 1);
insert into Users (Name, Surname, IsInADebt) values ('Stuart', 'Walworth', 1);
insert into Users (Name, Surname, IsInADebt) values ('Garrett', 'Hoyt', 0);
insert into Users (Name, Surname, IsInADebt) values ('Agna', 'Nott', 1);
insert into Users (Name, Surname, IsInADebt) values ('Hardy', 'Boland', 1);
insert into Users (Name, Surname, IsInADebt) values ('Danielle', 'Swainston', 0);
insert into Users (Name, Surname, IsInADebt) values ('Kirbee', 'Hele', 0);
insert into Users (Name, Surname, IsInADebt) values ('Darby', 'Gage', 1);
insert into Users (Name, Surname, IsInADebt) values ('Hazel', 'Margett', 1);
insert into Users (Name, Surname, IsInADebt) values ('Mame', 'Dugan', 0);
insert into Users (Name, Surname, IsInADebt) values ('Arabel', 'Robarts', 0);
insert into Users (Name, Surname, IsInADebt) values ('Toddy', 'Addionisio', 1);
insert into Users (Name, Surname, IsInADebt) values ('Christean', 'Bohling', 0);
insert into Users (Name, Surname, IsInADebt) values ('Nerta', 'Godin', 1);
insert into Users (Name, Surname, IsInADebt) values ('Alison', 'Poter', 1);
insert into Users (Name, Surname, IsInADebt) values ('Rosabel', 'Eberts', 1);
insert into Users (Name, Surname, IsInADebt) values ('Moselle', 'Klement', 1);
insert into Users (Name, Surname, IsInADebt) values ('Nessy', 'Lazar', 1);
insert into Users (Name, Surname, IsInADebt) values ('Barry', 'Dengel', 1);
insert into Users (Name, Surname, IsInADebt) values ('Perceval', 'Shalders', 1);
insert into Users (Name, Surname, IsInADebt) values ('Charisse', 'Sails', 0);
insert into Users (Name, Surname, IsInADebt) values ('Pansy', 'Silmon', 0);
insert into Users (Name, Surname, IsInADebt) values ('Giana', 'Avraam', 1);
insert into Users (Name, Surname, IsInADebt) values ('Chevy', 'Margrett', 0);
insert into Users (Name, Surname, IsInADebt) values ('Tallie', 'Jandourek', 1);
insert into Users (Name, Surname, IsInADebt) values ('Aymer', 'Hallyburton', 0);
insert into Users (Name, Surname, IsInADebt) values ('Ashley', 'Hendin', 0);
insert into Users (Name, Surname, IsInADebt) values ('Mil', 'Jahnke', 1);
insert into Users (Name, Surname, IsInADebt) values ('Gabbey', 'Sommerling', 1);
insert into Users (Name, Surname, IsInADebt) values ('Lambert', 'Czapla', 1);
insert into Users (Name, Surname, IsInADebt) values ('Gian', 'Avard', 0);
insert into Users (Name, Surname, IsInADebt) values ('Frederich', 'Rosettini', 0);
insert into Users (Name, Surname, IsInADebt) values ('Jakie', 'Ketch', 1);
insert into Users (Name, Surname, IsInADebt) values ('Meade', 'Finnick', 1);
insert into Users (Name, Surname, IsInADebt) values ('Bent', 'Marder', 0);
insert into Users (Name, Surname, IsInADebt) values ('Shirlee', 'Joscelyn', 0);
insert into Users (Name, Surname, IsInADebt) values ('Gard', 'Rivel', 1);
insert into Users (Name, Surname, IsInADebt) values ('Cello', 'Hansom', 1);
insert into Users (Name, Surname, IsInADebt) values ('Homere', 'Bovis', 1);
insert into Users (Name, Surname, IsInADebt) values ('Huey', 'Lockyer', 0);
insert into Users (Name, Surname, IsInADebt) values ('Sacha', 'Cratere', 0);
insert into Users (Name, Surname, IsInADebt) values ('Bidget', 'Stobart', 0);
insert into Users (Name, Surname, IsInADebt) values ('Rafaelia', 'Brotherton', 1);
insert into Users (Name, Surname, IsInADebt) values ('Adolpho', 'Belverstone', 0);
insert into Users (Name, Surname, IsInADebt) values ('Alissa', 'Squibbes', 0);
insert into Users (Name, Surname, IsInADebt) values ('Fabiano', 'Reville', 1);
insert into Users (Name, Surname, IsInADebt) values ('Darrin', 'Reicharz', 1);
insert into Users (Name, Surname, IsInADebt) values ('Jerrold', 'Leefe', 1);
insert into Users (Name, Surname, IsInADebt) values ('Fremont', 'Cromett', 1);
insert into Users (Name, Surname, IsInADebt) values ('Syd', 'Wetherburn', 1);
insert into Users (Name, Surname, IsInADebt) values ('Gerick', 'Bygrave', 1);
insert into Users (Name, Surname, IsInADebt) values ('Myrtle', 'Derington', 1);
insert into Users (Name, Surname, IsInADebt) values ('Sylvia', 'Devonish', 1);
insert into Users (Name, Surname, IsInADebt) values ('Gerti', 'Fitzhenry', 1);
insert into Users (Name, Surname, IsInADebt) values ('Linnea', 'Redmond', 1);
insert into Users (Name, Surname, IsInADebt) values ('Cathie', 'Sapson', 1);
insert into Users (Name, Surname, IsInADebt) values ('Lowrance', 'Godsell', 1);
insert into Users (Name, Surname, IsInADebt) values ('Emmalyn', 'Ertel', 0);
insert into Users (Name, Surname, IsInADebt) values ('Moe', 'Deppen', 0);
insert into Users (Name, Surname, IsInADebt) values ('Teri', 'Meatyard', 1);
insert into Users (Name, Surname, IsInADebt) values ('Flin', 'Gregolin', 1);
insert into Users (Name, Surname, IsInADebt) values ('Rouvin', 'Cranham', 1);
insert into Users (Name, Surname, IsInADebt) values ('Maryanna', 'Teers', 0);
insert into Users (Name, Surname, IsInADebt) values ('Alastair', 'Ramos', 0);
insert into Users (Name, Surname, IsInADebt) values ('Madeline', 'MacFaul', 1);
insert into Users (Name, Surname, IsInADebt) values ('Marcelo', 'Lowers', 0);
insert into Users (Name, Surname, IsInADebt) values ('Catriona', 'Borth', 0);
insert into Users (Name, Surname, IsInADebt) values ('Valentina', 'Castellone', 1);
insert into Users (Name, Surname, IsInADebt) values ('Sindee', 'Faers', 1);
insert into Users (Name, Surname, IsInADebt) values ('Ruthanne', 'Stollen', 1);
insert into Users (Name, Surname, IsInADebt) values ('Aube', 'Pendered', 0);
insert into Users (Name, Surname, IsInADebt) values ('Jorry', 'MacArd', 0);
insert into Users (Name, Surname, IsInADebt) values ('Jodie', 'Stripp', 0);
insert into Users (Name, Surname, IsInADebt) values ('Charmine', 'Diego', 1);
insert into Users (Name, Surname, IsInADebt) values ('Kordula', 'Kinneally', 1);
insert into Users (Name, Surname, IsInADebt) values ('Cad', 'Oxburgh', 1);
insert into Users (Name, Surname, IsInADebt) values ('Letti', 'Christophers', 0);
insert into Users (Name, Surname, IsInADebt) values ('Nathalie', 'Botler', 0);
insert into Users (Name, Surname, IsInADebt) values ('Emlyn', 'McCrie', 0);
insert into Users (Name, Surname, IsInADebt) values ('Barry', 'Buesden', 1);
insert into Users (Name, Surname, IsInADebt) values ('Annabela', 'Dyter', 0);
insert into Users (Name, Surname, IsInADebt) values ('Uriah', 'Pyrton', 1);

insert into UserBookConn (BookId, UserId) values (31, 47);
insert into UserBookConn (BookId, UserId) values (47, 30);
insert into UserBookConn (BookId, UserId) values (44, 60);
insert into UserBookConn (BookId, UserId) values (29, 75);
insert into UserBookConn (BookId, UserId) values (62, 79);
insert into UserBookConn (BookId, UserId) values (4, 83);
insert into UserBookConn (BookId, UserId) values (78, 100);
insert into UserBookConn (BookId, UserId) values (46, 96);
insert into UserBookConn (BookId, UserId) values (70, 95);
insert into UserBookConn (BookId, UserId) values (15, 33);
insert into UserBookConn (BookId, UserId) values (9, 45);
insert into UserBookConn (BookId, UserId) values (37, 7);
insert into UserBookConn (BookId, UserId) values (17, 15);
insert into UserBookConn (BookId, UserId) values (25, 94);
insert into UserBookConn (BookId, UserId) values (72, 68);
insert into UserBookConn (BookId, UserId) values (93, 70);
insert into UserBookConn (BookId, UserId) values (20, 15);
insert into UserBookConn (BookId, UserId) values (18, 23);
insert into UserBookConn (BookId, UserId) values (70, 87);
insert into UserBookConn (BookId, UserId) values (12, 91);
insert into UserBookConn (BookId, UserId) values (31, 15);
insert into UserBookConn (BookId, UserId) values (66, 33);
insert into UserBookConn (BookId, UserId) values (27, 82);
insert into UserBookConn (BookId, UserId) values (20, 69);
insert into UserBookConn (BookId, UserId) values (32, 55);
insert into UserBookConn (BookId, UserId) values (7, 4);
insert into UserBookConn (BookId, UserId) values (92, 46);
insert into UserBookConn (BookId, UserId) values (23, 2);
insert into UserBookConn (BookId, UserId) values (89, 43);
insert into UserBookConn (BookId, UserId) values (65, 35);
insert into UserBookConn (BookId, UserId) values (6, 32);
insert into UserBookConn (BookId, UserId) values (8, 95);
insert into UserBookConn (BookId, UserId) values (52, 39);
insert into UserBookConn (BookId, UserId) values (88, 63);
insert into UserBookConn (BookId, UserId) values (93, 86);
insert into UserBookConn (BookId, UserId) values (62, 30);
insert into UserBookConn (BookId, UserId) values (6, 36);
insert into UserBookConn (BookId, UserId) values (25, 67);
insert into UserBookConn (BookId, UserId) values (53, 13);
insert into UserBookConn (BookId, UserId) values (30, 63);
insert into UserBookConn (BookId, UserId) values (81, 58);
insert into UserBookConn (BookId, UserId) values (31, 27);
insert into UserBookConn (BookId, UserId) values (45, 97);
insert into UserBookConn (BookId, UserId) values (100, 59);
insert into UserBookConn (BookId, UserId) values (68, 97);
insert into UserBookConn (BookId, UserId) values (37, 37);
insert into UserBookConn (BookId, UserId) values (56, 5);
insert into UserBookConn (BookId, UserId) values (65, 52);
insert into UserBookConn (BookId, UserId) values (58, 56);
insert into UserBookConn (BookId, UserId) values (26, 99);
insert into UserBookConn (BookId, UserId) values (94, 16);
insert into UserBookConn (BookId, UserId) values (14, 42);
insert into UserBookConn (BookId, UserId) values (50, 32);
insert into UserBookConn (BookId, UserId) values (27, 21);
insert into UserBookConn (BookId, UserId) values (18, 94);
insert into UserBookConn (BookId, UserId) values (39, 8);
insert into UserBookConn (BookId, UserId) values (59, 94);
insert into UserBookConn (BookId, UserId) values (42, 66);
insert into UserBookConn (BookId, UserId) values (73, 48);
insert into UserBookConn (BookId, UserId) values (64, 66);
insert into UserBookConn (BookId, UserId) values (7, 76);
insert into UserBookConn (BookId, UserId) values (86, 68);
insert into UserBookConn (BookId, UserId) values (83, 62);
insert into UserBookConn (BookId, UserId) values (20, 48);
insert into UserBookConn (BookId, UserId) values (35, 48);
insert into UserBookConn (BookId, UserId) values (81, 51);
insert into UserBookConn (BookId, UserId) values (23, 94);
insert into UserBookConn (BookId, UserId) values (10, 72);
insert into UserBookConn (BookId, UserId) values (46, 16);
insert into UserBookConn (BookId, UserId) values (72, 37);
insert into UserBookConn (BookId, UserId) values (8, 66);
insert into UserBookConn (BookId, UserId) values (46, 90);
insert into UserBookConn (BookId, UserId) values (86, 29);
insert into UserBookConn (BookId, UserId) values (31, 72);
insert into UserBookConn (BookId, UserId) values (51, 81);
insert into UserBookConn (BookId, UserId) values (57, 21);
insert into UserBookConn (BookId, UserId) values (26, 2);
insert into UserBookConn (BookId, UserId) values (47, 30);
insert into UserBookConn (BookId, UserId) values (63, 67);
insert into UserBookConn (BookId, UserId) values (68, 16);
insert into UserBookConn (BookId, UserId) values (10, 40);
insert into UserBookConn (BookId, UserId) values (99, 9);
insert into UserBookConn (BookId, UserId) values (99, 80);
insert into UserBookConn (BookId, UserId) values (9, 70);
insert into UserBookConn (BookId, UserId) values (33, 82);
insert into UserBookConn (BookId, UserId) values (48, 74);
insert into UserBookConn (BookId, UserId) values (98, 94);
insert into UserBookConn (BookId, UserId) values (23, 30);
insert into UserBookConn (BookId, UserId) values (59, 77);
insert into UserBookConn (BookId, UserId) values (32, 52);
insert into UserBookConn (BookId, UserId) values (69, 49);
insert into UserBookConn (BookId, UserId) values (62, 7);
insert into UserBookConn (BookId, UserId) values (53, 46);
insert into UserBookConn (BookId, UserId) values (64, 93);
insert into UserBookConn (BookId, UserId) values (31, 41);
insert into UserBookConn (BookId, UserId) values (67, 68);
insert into UserBookConn (BookId, UserId) values (37, 34);
insert into UserBookConn (BookId, UserId) values (88, 45);
insert into UserBookConn (BookId, UserId) values (84, 57);
insert into UserBookConn (BookId, UserId) values (56, 75);

insert into AuthorBookConn (BookId, AuthorId) values (89, 27);
insert into AuthorBookConn (BookId, AuthorId) values (56, 54);
insert into AuthorBookConn (BookId, AuthorId) values (79, 33);
insert into AuthorBookConn (BookId, AuthorId) values (65, 62);
insert into AuthorBookConn (BookId, AuthorId) values (9, 83);
insert into AuthorBookConn (BookId, AuthorId) values (87, 85);
insert into AuthorBookConn (BookId, AuthorId) values (19, 7);
insert into AuthorBookConn (BookId, AuthorId) values (58, 62);
insert into AuthorBookConn (BookId, AuthorId) values (58, 63);
insert into AuthorBookConn (BookId, AuthorId) values (37, 22);
insert into AuthorBookConn (BookId, AuthorId) values (84, 89);
insert into AuthorBookConn (BookId, AuthorId) values (5, 2);
insert into AuthorBookConn (BookId, AuthorId) values (32, 26);
insert into AuthorBookConn (BookId, AuthorId) values (21, 53);
insert into AuthorBookConn (BookId, AuthorId) values (85, 55);
insert into AuthorBookConn (BookId, AuthorId) values (69, 66);
insert into AuthorBookConn (BookId, AuthorId) values (95, 64);
insert into AuthorBookConn (BookId, AuthorId) values (55, 21);
insert into AuthorBookConn (BookId, AuthorId) values (25, 23);
insert into AuthorBookConn (BookId, AuthorId) values (40, 17);
insert into AuthorBookConn (BookId, AuthorId) values (19, 69);
insert into AuthorBookConn (BookId, AuthorId) values (97, 73);
insert into AuthorBookConn (BookId, AuthorId) values (82, 63);
insert into AuthorBookConn (BookId, AuthorId) values (69, 24);
insert into AuthorBookConn (BookId, AuthorId) values (10, 90);
insert into AuthorBookConn (BookId, AuthorId) values (22, 62);
insert into AuthorBookConn (BookId, AuthorId) values (33, 84);
insert into AuthorBookConn (BookId, AuthorId) values (26, 60);
insert into AuthorBookConn (BookId, AuthorId) values (4, 18);
insert into AuthorBookConn (BookId, AuthorId) values (90, 50);
insert into AuthorBookConn (BookId, AuthorId) values (30, 36);
insert into AuthorBookConn (BookId, AuthorId) values (1, 20);
insert into AuthorBookConn (BookId, AuthorId) values (28, 57);
insert into AuthorBookConn (BookId, AuthorId) values (25, 61);
insert into AuthorBookConn (BookId, AuthorId) values (79, 77);
insert into AuthorBookConn (BookId, AuthorId) values (78, 43);
insert into AuthorBookConn (BookId, AuthorId) values (39, 87);
insert into AuthorBookConn (BookId, AuthorId) values (74, 12);
insert into AuthorBookConn (BookId, AuthorId) values (85, 46);
insert into AuthorBookConn (BookId, AuthorId) values (1, 31);
insert into AuthorBookConn (BookId, AuthorId) values (98, 4);
insert into AuthorBookConn (BookId, AuthorId) values (84, 24);
insert into AuthorBookConn (BookId, AuthorId) values (33, 29);
insert into AuthorBookConn (BookId, AuthorId) values (47, 21);
insert into AuthorBookConn (BookId, AuthorId) values (72, 37);
insert into AuthorBookConn (BookId, AuthorId) values (27, 74);
insert into AuthorBookConn (BookId, AuthorId) values (100, 51);
insert into AuthorBookConn (BookId, AuthorId) values (19, 95);
insert into AuthorBookConn (BookId, AuthorId) values (5, 6);
insert into AuthorBookConn (BookId, AuthorId) values (27, 2);
insert into AuthorBookConn (BookId, AuthorId) values (49, 75);
insert into AuthorBookConn (BookId, AuthorId) values (81, 45);
insert into AuthorBookConn (BookId, AuthorId) values (13, 54);
insert into AuthorBookConn (BookId, AuthorId) values (88, 82);
insert into AuthorBookConn (BookId, AuthorId) values (44, 13);
insert into AuthorBookConn (BookId, AuthorId) values (11, 58);
insert into AuthorBookConn (BookId, AuthorId) values (82, 7);
insert into AuthorBookConn (BookId, AuthorId) values (44, 4);
insert into AuthorBookConn (BookId, AuthorId) values (68, 72);
insert into AuthorBookConn (BookId, AuthorId) values (21, 58);
insert into AuthorBookConn (BookId, AuthorId) values (25, 48);
insert into AuthorBookConn (BookId, AuthorId) values (57, 15);
insert into AuthorBookConn (BookId, AuthorId) values (52, 8);
insert into AuthorBookConn (BookId, AuthorId) values (22, 98);
insert into AuthorBookConn (BookId, AuthorId) values (28, 2);
insert into AuthorBookConn (BookId, AuthorId) values (85, 23);
insert into AuthorBookConn (BookId, AuthorId) values (41, 53);
insert into AuthorBookConn (BookId, AuthorId) values (71, 94);
insert into AuthorBookConn (BookId, AuthorId) values (82, 79);
insert into AuthorBookConn (BookId, AuthorId) values (89, 57);
insert into AuthorBookConn (BookId, AuthorId) values (47, 94);
insert into AuthorBookConn (BookId, AuthorId) values (47, 64);
insert into AuthorBookConn (BookId, AuthorId) values (58, 20);
insert into AuthorBookConn (BookId, AuthorId) values (21, 22);
insert into AuthorBookConn (BookId, AuthorId) values (86, 27);
insert into AuthorBookConn (BookId, AuthorId) values (18, 3);
insert into AuthorBookConn (BookId, AuthorId) values (96, 21);
insert into AuthorBookConn (BookId, AuthorId) values (77, 18);
insert into AuthorBookConn (BookId, AuthorId) values (17, 22);
insert into AuthorBookConn (BookId, AuthorId) values (48, 20);
insert into AuthorBookConn (BookId, AuthorId) values (43, 31);
insert into AuthorBookConn (BookId, AuthorId) values (42, 40);
insert into AuthorBookConn (BookId, AuthorId) values (20, 63);
insert into AuthorBookConn (BookId, AuthorId) values (35, 36);
insert into AuthorBookConn (BookId, AuthorId) values (33, 81);
insert into AuthorBookConn (BookId, AuthorId) values (43, 14);
insert into AuthorBookConn (BookId, AuthorId) values (63, 51);
insert into AuthorBookConn (BookId, AuthorId) values (47, 7);
insert into AuthorBookConn (BookId, AuthorId) values (82, 7);
insert into AuthorBookConn (BookId, AuthorId) values (78, 56);
insert into AuthorBookConn (BookId, AuthorId) values (36, 23);
insert into AuthorBookConn (BookId, AuthorId) values (80, 24);
insert into AuthorBookConn (BookId, AuthorId) values (95, 27);
insert into AuthorBookConn (BookId, AuthorId) values (96, 6);
insert into AuthorBookConn (BookId, AuthorId) values (29, 81);
insert into AuthorBookConn (BookId, AuthorId) values (35, 37);
insert into AuthorBookConn (BookId, AuthorId) values (63, 43);
insert into AuthorBookConn (BookId, AuthorId) values (55, 12);
insert into AuthorBookConn (BookId, AuthorId) values (84, 17);
insert into AuthorBookConn (BookId, AuthorId) values (88, 91);
*/
