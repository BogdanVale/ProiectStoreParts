using Microsoft.EntityFrameworkCore;
using ProiectII.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProiectII.Repository
{
    public class PartsRepository : IPartsRepository
    {
        private readonly AppDbContext _appDbContext;

        public PartsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Part> AllParts
        {
            get
            {
                return _appDbContext.Parts.Include(c => c.Category);
            }
        }

        public IEnumerable<Part> DiscountParts
        {
            get
            {
                return _appDbContext.Parts.Include(c => c.Category).Where(p => p.Discount);
            }
        }

        public Part GetPartById(int partId)
        {
            return _appDbContext.Parts.FirstOrDefault(p => p.PartId == partId);
        }
    }
}
