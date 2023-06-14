using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TO_SQL
{
    public class LibraryLTS_DB_Task
    {
        private DBLibraryDataContext dataContext = new DBLibraryDataContext();
        public IEnumerable<Books> GetAllBooksByCurrentCountPages(int pages_count)
        {
            return dataContext.Books.Where(x => x.Pages > pages_count);
        }
        public IEnumerable<Books> GetAllBooksWithTheNameStartsByCurrentLetter(char letter_name_starts)
        {
            return dataContext.Books.Where(x => x.Name[0] == Char.ToUpper(letter_name_starts));
        }
        public IEnumerable<Books> GetAllBooksOfACurrentAuthorByHisNameAndSurname(string authors_name, string authors_surname)
        {
            return dataContext.Books.Where(x => x.Authors.Name == authors_name && x.Authors.Surname == authors_surname);
        }
        public IEnumerable<Books> GetAllBooksWithACurrentCountrySortedByAlphabetQueue(string country_name)
        {
            return dataContext.Books.Where(x => x.Authors.Countries.Name == country_name).OrderBy(x => x.Authors.Countries.Name);
        }
        public IEnumerable<Books> GetAllBooksByTheLengthOfANameInIt(int length_of_a_name)
        {
            return dataContext.Books.Where(x => x.Name.Length < length_of_a_name);
        }
        public IEnumerable<Books> GetBookWithTheMaxPagesCountOfACurrentCountry(string country_name)
        {
            return dataContext.Books.OrderByDescending(x => x.Pages == dataContext.Books.Min(y => y.Pages) && x.Authors.Countries.Name == country_name);
        }
        public IEnumerable<Authors> GetAuthorWithTheLowestCountOfBooks()
        {
            return dataContext.Authors.Where(x => x.Books.Count() == dataContext.Authors.Min(y => y.Books.Count()));
        }
        public IEnumerable<Countries> GetCountryWithTheHighestCountOfAuthors()
        {
            return dataContext.Countries.Where(x => x.Authors.Count() == dataContext.Countries.Max(y => y.Authors.Count()));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LibraryLTS_DB_Task lib = new LibraryLTS_DB_Task();

            Console.WriteLine("1 - GetAllBooksByCurrentCountPages");
            Console.WriteLine("2 - GetAllBooksByTheLengthOfANameInIt");
            Console.WriteLine("3 - GetAllBooksOfACurrentAuthorByHisNameAndSurname");
            Console.WriteLine("4 - GetAllBooksWithACurrentCountrySortedByAlphabetQueue");
            Console.WriteLine("5 - GetAllBooksWithTheNameStartsByCurrentLetter"); 
            Console.WriteLine("6 - GetAllBooksWithTheNameStartsByCurrentLetter");
            Console.WriteLine("7 - GetBookWithTheMaxPagesCountOfACurrentCountry");
            Console.WriteLine("8 - GetCountryWithTheHighestCountOfAuthors");
            string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        {
                            foreach (Books item in lib.GetAllBooksByCurrentCountPages(200))
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}, {item.Pages}, {item.AuthorId}");
                            }
                        }
                        break;
                    case "2":
                        {
                            foreach (Books item in lib.GetAllBooksByTheLengthOfANameInIt(1))
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}, {item.Pages}, {item.AuthorId}");
                            }
                        }
                        break;
                    case "3":
                        {
                            foreach (Books item in lib.GetAllBooksOfACurrentAuthorByHisNameAndSurname("Gawain", "Badwick"))
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}, {item.Pages}, {item.AuthorId}");
                            }
                        }
                        break;
                    case "4":
                        {
                            foreach (Books item in lib.GetAllBooksWithACurrentCountrySortedByAlphabetQueue("Indonesia"))
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}, {item.Pages}, {item.AuthorId}");
                            }
                        }
                        break;
                    case "5":
                        {
                            foreach (Books item in lib.GetAllBooksWithTheNameStartsByCurrentLetter('n'))
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}, {item.Pages}, {item.AuthorId}");
                            }
                        }
                        break;
                    case "6":
                        {
                            foreach (Authors item in lib.GetAuthorWithTheLowestCountOfBooks())
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}, {item.Surname}");
                            }
                        }
                        break;
                    case "7":
                        {
                            foreach (Books item in lib.GetBookWithTheMaxPagesCountOfACurrentCountry("China"))
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}");
                            }
                        }
                        break;
                    case "8":
                        {
                            foreach (Countries item in lib.GetCountryWithTheHighestCountOfAuthors())
                            {
                                Console.WriteLine($"{item.Id}, {item.Name}");
                            }
                        }
                        break;
                    default: 
                        break;
            }
        }
    }
}
