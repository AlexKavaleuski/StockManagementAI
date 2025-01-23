using System;
using System.Collections.Generic;
using System.Linq;
using StockManagementAI.Models;

namespace StockManagementAI.Repositories
{
    public class InMemoryStockRepository : IStockRepository
    {
        private readonly List<StockItem> _stocks = new();

        public void AddStock(StockItem stock)
        {
            if (_stocks.Any(s => s.ISIN == stock.ISIN))
                throw new InvalidOperationException("Stock with this ISIN already exists.");
            _stocks.Add(stock);
        }

        public void UpdateStock(string isin, decimal? price, int? quantity)
        {
            var stock = _stocks.FirstOrDefault(s => s.ISIN == isin);
            if (stock == null)
                throw new KeyNotFoundException("Stock not found.");

            if (price.HasValue) stock.Price = price.Value;
            if (quantity.HasValue) stock.Quantity = quantity.Value;
        }

        public IEnumerable<StockItem> GetAllStocks() => _stocks;

        public IEnumerable<StockItem> GetStocksBelowThreshold(int threshold)
        {
            return _stocks.Where(s => s.Quantity < threshold);
        }

        public StockItem GetStockByISIN(string isin)
        {
            return _stocks.FirstOrDefault(s => s.ISIN == isin);
        }

        public IEnumerable<StockItem> SearchStockByName(string namePart)
        {
            return _stocks.Where(s => s.Name.Contains(namePart));
        }
    }
}
