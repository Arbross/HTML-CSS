using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models
{
    public class HomeViewModel
    {
        public int Hours { get; set; }
        public bool IsStarted { get; set; }
        public List<Link> Links { get; set; }
    }
}
