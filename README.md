Stock Management System

Overview

This is a simple Stock Management System developed in .NET Framework 4.5. It allows users to manage stock items (financial instruments) using an in-memory storage system. The system provides functionalities such as adding, updating, listing, and searching for stocks.

Features

Add Stock: Prevents duplicate ISIN entries.

Update Stock: Updates stock price and quantity by ISIN.

List All Stocks: Displays all stored stock items.

Query Below Threshold: Finds stocks with quantity below a given threshold.

Search Stock: Supports searching by ISIN or partial name using LINQ.

Technology Stack

.NET Framework 4.5

C#

Console Application

LINQ for searching/filtering

Project Structure

StockManagementSystem/
│-- Models/
│   ├── StockItem.cs
│-- Repositories/
│   ├── IStockRepository.cs
│   ├── InMemoryStockRepository.cs
│-- Services/
│   ├── StockService.cs
│-- Program.cs

Installation & Running the Application

Clone or download the repository.

Open the project in Visual Studio.

Build the solution.

Run the application using the Visual Studio Debugger or execute the compiled .exe from the bin folder.

Usage

Add Stock

Enter ISIN, Name, Price, and Quantity.

Update Stock

Provide ISIN and update Price or Quantity.

List All Stocks

Displays all stock items in the repository.

Query Stocks Below a Threshold

Enter a quantity threshold to filter stocks.

Search Stock By Name

Enter a name or partial name to search.

Exit

Close the application.

Example Console Interaction

Stock Management System
1. Add Stock
2. Update Stock
3. List All Stocks
4. Query Stocks Below Threshold
5. Search Stock By Name
6. Exit
Enter choice: 1
Enter ISIN: US1234567890
Enter Name: Apple Inc.
Enter Price: 150.75
Enter Quantity: 50
Stock added successfully!

Future Enhancements

Implement SQLite database support.

Add a graphical user interface.

Introduce stock category classifications.

License

This project is released under the MIT License.
