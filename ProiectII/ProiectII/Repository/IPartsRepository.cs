using ProiectII.Models;
using System.Collections.Generic;

namespace ProiectII.Repository
{
    public interface IPartsRepository
    {
        IEnumerable<Part> AllParts { get; }
        IEnumerable<Part> DiscountParts { get; }
        Part GetPartById(int partId);
    }
}
