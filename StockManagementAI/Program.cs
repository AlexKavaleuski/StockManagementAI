using StockManagementAI.Repositories;
using StockManagementAI.Services;
using System;

namespace StockManagementAI
{
    internal class Program
    {
        static void Main()
        {
            IStockRepository repository = new InMemoryStockRepository();
            StockService service = new StockService(repository);

            while (true)
            {
                Console.WriteLine("\nStock Management System");
                Console.WriteLine("1. Add Stock");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. List All Stocks");
                Console.WriteLine("4. Query Stocks Below Threshold");
                Console.WriteLine("5. Search Stock By Name");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter ISIN: ");
                        string isin = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        service.AddStock(isin, name, price, quantity);
                        break;
                    case "2":
                        Console.Write("Enter ISIN: ");
                        string updateIsin = Console.ReadLine();
                        Console.Write("Enter New Price (leave empty to skip): ");
                        decimal? newPrice = decimal.TryParse(Console.ReadLine(), out decimal tempPrice) ? tempPrice : null;
                        Console.Write("Enter New Quantity (leave empty to skip): ");
                        int? newQuantity = int.TryParse(Console.ReadLine(), out int tempQty) ? tempQty : null;
                        service.UpdateStock(updateIsin, newPrice, newQuantity);
                        break;
                    case "3":
                        foreach (var stock in service.GetAllStocks())
                            Console.WriteLine($"{stock.ISIN} - {stock.Name} - {stock.Price} - {stock.Quantity}");
                        break;
                    case "4":
                        Console.Write("Enter threshold: ");
                        int threshold = int.Parse(Console.ReadLine());
                        foreach (var stock in service.GetStocksBelowThreshold(threshold))
                            Console.WriteLine($"{stock.ISIN} - {stock.Name} - {stock.Price} - {stock.Quantity}");
                        break;
                    case "5":
                        Console.Write("Enter name part: ");
                        string namePart = Console.ReadLine();
                        foreach (var stock in service.SearchStockByName(namePart))
                            Console.WriteLine($"{stock.ISIN} - {stock.Name} - {stock.Price} - {stock.Quantity}");
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
