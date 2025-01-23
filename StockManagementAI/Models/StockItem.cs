using System;

namespace StockManagementAI.Models
{
    public class StockItem
    {
        public string ISIN { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public StockItem(string isin, string name, decimal price, int quantity)
        {
            ISIN = isin ?? throw new ArgumentNullException(nameof(isin));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
            Quantity = quantity;
        }
    }
}
