using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProiectII.Models;
using ProiectII.Repository;
using ProiectII.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectII.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPartsRepository _partsRepository;

        public HomeController(IPartsRepository partsRepository)
        {
            _partsRepository = partsRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                DiscountParts = _partsRepository.DiscountParts
            };

            return View(homeViewModel);
        }
    }
}
