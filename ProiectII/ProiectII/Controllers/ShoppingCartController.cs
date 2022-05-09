using Microsoft.AspNetCore.Mvc;
using ProiectII.Models;
using ProiectII.Repository;
using ProiectII.ViewModel;
using System.Linq;

namespace ProiectII.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPartsRepository _partsRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPartsRepository partsRepository, ShoppingCart shoppingCart)
        {
            _partsRepository = partsRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int partId)
        {
            var selectedPart = _partsRepository.AllParts.FirstOrDefault(p => p.PartId == partId);

            if (selectedPart != null)
            {
                _shoppingCart.AddToCart(selectedPart, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int partId)
        {
            var selectedPart = _partsRepository.AllParts.FirstOrDefault(p => p.PartId == partId);

            if (selectedPart != null)
            {
                _shoppingCart.RemoveFromCart(selectedPart);
            }
            return RedirectToAction("Index");
        }
    }
}
