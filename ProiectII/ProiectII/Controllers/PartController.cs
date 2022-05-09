using Microsoft.AspNetCore.Mvc;
using ProiectII.Models;
using ProiectII.Repository;
using ProiectII.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProiectII.Controllers
{
    public class PartController : Controller
    {
        private readonly IPartsRepository _partsRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PartController(IPartsRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _partsRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

       

        public ViewResult List(string category)
        {
            IEnumerable<Part> parts;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                parts = _partsRepository.AllParts.OrderBy(p => p.PartId);
                currentCategory = "All parts";
            }
            else
            {
                parts = _partsRepository.AllParts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PartId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PartsListViewModel
            {
                Parts = parts,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var part = _partsRepository.GetPartById(id);
            if (part == null)
                return NotFound();

            return View(part);  
        }
    }
}
