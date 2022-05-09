using System.Collections.Generic;

namespace ProiectII.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Part> Pies { get; set; }
    }
}
