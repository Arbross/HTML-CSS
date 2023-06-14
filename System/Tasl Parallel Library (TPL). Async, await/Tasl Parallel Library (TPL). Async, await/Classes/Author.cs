using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasl_Parallel_Library__TPL_.Async__await
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Surname : {Surname}";
        }

        public virtual ICollection<Book> Books { get; set; }
    }
}
