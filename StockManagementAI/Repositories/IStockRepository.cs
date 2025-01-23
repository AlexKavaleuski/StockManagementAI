using StockManagementAI.Models;
using System.Collections.Generic;

namespace StockManagementAI.Repositories
{
    public interface IStockRepository
    {
        void AddStock(StockItem stock);
        void UpdateStock(string isin, decimal? price, int? quantity);
        IEnumerable<StockItem> GetAllStocks();
        IEnumerable<StockItem> GetStocksBelowThreshold(int threshold);
        StockItem GetStockByISIN(string isin);
        IEnumerable<StockItem> SearchStockByName(string namePart);
    }
}
