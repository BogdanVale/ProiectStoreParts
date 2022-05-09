using ProiectII.Models;
using System.Collections.Generic;

namespace ProiectII.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
