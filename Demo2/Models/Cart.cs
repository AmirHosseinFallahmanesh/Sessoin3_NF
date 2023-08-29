using System.Collections.Generic;

namespace Demo2.Models
{
    public class Cart
    {
        public string Username { get; set; }
        public List<CartLine> CartLines { get; set; }
    }

    public class CartLine
    {
        public string ProductName { get; set; }
        public int Count { get; set; }
    }
}
