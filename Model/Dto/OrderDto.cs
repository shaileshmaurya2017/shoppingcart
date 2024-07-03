namespace ShoppingCart.Model.Dto
{
    public class OrderDto
    {
        public int userId { get; set; }
        public CartData[] cart { get; set; }

    }
    public class CartData
    {
        public int qty { get; set; }
        public double price { get; set; }
        public int ProductId { get; set; }
    }
}
