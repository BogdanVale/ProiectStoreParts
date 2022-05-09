namespace ProiectII.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Part Part { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
