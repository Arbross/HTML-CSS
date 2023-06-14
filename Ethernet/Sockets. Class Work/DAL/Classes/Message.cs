using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Message
    {
        public int Id { get; set; }
        public string UseMessage { get; set; }
        
        public virtual Categoria Categoria { get; set; }
    }
}
