using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class ProductRepository
    {
        public string name;
        public int stock;
        public decimal price;
        public int categoryId;
        public void InputName()
        {
            Console.Write("Enter Name: ");
            while (string.IsNullOrEmpty(name)) 
            {
                Console.ReadLine();            
            }
        }

        public void InputPrice()
        {
            Console.Write("Enter Price: ");
            if (!decimal.TryParse(Console.ReadLine(), out  price))
            {
                Console.WriteLine("Error, Please input valid price");
                InputPrice();
            }
        }

        public void InputStock()
        {
            Console.Write("Enter Stock: ");
            if (!Int32.TryParse(Console.ReadLine(), out  stock))
            {
                Console.WriteLine("Error, Please input valid price");
                InputStock();
            }
        }

        public void InputCategoryId()
        {
            Console.Write("Enter Category Id: ");
            if (!Int32.TryParse(Console.ReadLine(), out categoryId))
            {
                Console.WriteLine("Error, Please input valid price");
                InputCategoryId();
            }
        }
        public void AddProduct(SqlConnection sqlConnection)
        {
            InputName();
            InputPrice();
            InputStock();
            InputCategoryId();
          
            
            var insertQuery = $"INSERT INTO dbo.Products(Name, Price, Stock, CategoryId) VALUES(@Name, @Price, @Stock, @CategoryId) ";

            sqlConnection.Execute(insertQuery, new { Name = name,Price = price, Stock = stock, CategoryId = categoryId});
        }


        public void ListAllProducts(SqlConnection sqlConnection)
        {
            string selectQuery = "SELECT Name, Price, Stock, CategoryId FROM Products ";
            var products1 = sqlConnection.Query<Products>(selectQuery);
;            foreach(var product in products1)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}, CategoryId: {product.CategoryId}");
            }
        }

    }
}
