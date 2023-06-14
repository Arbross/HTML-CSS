using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasl_Parallel_Library__TPL_.Async__await
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        [ForeignKey("Authors")]
        public int? AuthorId { get; set; }
        public override string ToString()
        {
            return $"Id : {Id}, Book Name : {BookName}";
        }
        public virtual Author Authors { get; set; }
    }
}
