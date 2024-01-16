using Microsoft.Data.SqlClient;

namespace InventoryManagementSystem;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Choose Your Option:");
        Console.WriteLine("1.Add Product");
        Console.WriteLine("2.List All Products");
        Console.WriteLine("3.Record a Sale");
        Console.WriteLine("4.Delete Product");
        Console.WriteLine("5.Exit");

    }   
    static void InputMenuChoice(SalesRepository salesRepo, ProductRepository productRepo,SqlConnection sqlConnection)
    {
          int MenuChoice = Convert.ToInt32(Console.ReadLine());

        switch (MenuChoice)
        {
            case 1:
                productRepo.AddProduct(sqlConnection);
                break;
            case 2:
                productRepo.ListAllProducts(sqlConnection); 
                break;
            case 3:
                salesRepo.RecordNewSale(sqlConnection);
                break;
        }
    }
    static void Main()
    {
        DisplayMenu();
        CategoriesSetup dbSetup = new CategoriesSetup();
        ProductRepository productRepository = new ProductRepository();
        SalesRepository salesRepository = new SalesRepository();
        var connectionString = "Server =LHO10068951\\SQLEXPRESS; Database = InventoryManagementSystem;Integrated Security=SSPI; TrustServerCertificate=True;";
        using (var connection = new SqlConnection(connectionString))
        {

            connection.Open();
            InputMenuChoice(salesRepository, productRepository, connection);
            
            connection.Close();
        }
        
    }
}