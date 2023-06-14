using System.ComponentModel.DataAnnotations.Schema;

namespace DomainChecker.Classes
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public string CheckUrl { get; set; } // Ссылка для проверки парсинга цен
        public string LogoUrl { get; set; }
        public bool CheckedNoStock { get; set; }
        public bool CheckedAuction { get; set; }
        public bool CheckedDefaultPattern { get; set; }
        public bool AlwaysRequestFromBrowser { get; set; }
        public bool IsSolved { get; set; }
        public bool IsArchived { get; set; }

        public bool IsMovedToSuperPattern { get; set; }

        [NotMapped]
        public int CountForAccount { get; set; }

        public override string ToString()
        {
            return $"{Domain} , {Id} , {LogoUrl}";
        }
    }
}
