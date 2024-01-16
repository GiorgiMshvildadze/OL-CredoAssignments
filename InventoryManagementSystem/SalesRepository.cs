using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class SalesRepository
    {
        public int productId;
        public int quantity;
       
        public void InputProductId()
        {
            Console.WriteLine("Enter ProductID: ");
            if (!Int32.TryParse(Console.ReadLine(), out productId))
            {
                Console.WriteLine("Enter Valid Id");
                InputProductId();
            }
        }

        public void InputQuantity()
        {
            Console.WriteLine("Input Quantity");
            if (!Int32.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Enter Valid Number");
                InputQuantity();
            }
        }
        public void RecordNewSale(SqlConnection sqlConnection)
        {
            InputProductId();
            InputQuantity();

            var saleInsertQuery = "INSERT INTO dbo.Sales(ProductId, Quantity, SaleDate) VALUES (@ProductId, @Quantity, @SaleDate)";
            sqlConnection.Execute(saleInsertQuery, new { ProductId = productId, Quantity = quantity, SaleDate = DateTime.Now});

        }
    }
}
