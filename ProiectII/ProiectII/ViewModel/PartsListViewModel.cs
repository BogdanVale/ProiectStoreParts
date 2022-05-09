using ProiectII.Models;
using System.Collections.Generic;

namespace ProiectII.ViewModel
{
    public class PartsListViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
        public string CurrentCategory { get; set; }
    }
}
