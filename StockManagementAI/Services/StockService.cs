using System;
using System.Collections.Generic;
using StockManagementAI.Models;
using StockManagementAI.Repositories;

namespace StockManagementAI.Services
{
    public class StockService
    {
        private readonly IStockRepository _repository;

        public StockService(IStockRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public void AddStock(string isin, string name, decimal price, int quantity)
        {
            var stock = new StockItem(isin, name, price, quantity);
            _repository.AddStock(stock);
        }

        public void UpdateStock(string isin, decimal? price, int? quantity)
        {
            _repository.UpdateStock(isin, price, quantity);
        }

        public IEnumerable<StockItem> GetAllStocks()
        {
            return _repository.GetAllStocks();
        }

        public IEnumerable<StockItem> GetStocksBelowThreshold(int threshold)
        {
            return _repository.GetStocksBelowThreshold(threshold);
        }

        public StockItem GetStockByISIN(string isin)
        {
            return _repository.GetStockByISIN(isin);
        }

        public IEnumerable<StockItem> SearchStockByName(string namePart)
        {
            return _repository.SearchStockByName(namePart);
        }
    }
}
