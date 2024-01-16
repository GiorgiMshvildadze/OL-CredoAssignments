using Microsoft.Data.SqlClient;

namespace DapperBookLibrary;

class Program
{
     static void InsertSql()
    {
        var insertSql = "Insert Into Author(Name, Age) Values (Author15, 47)";

    }
    static void Main()
    {
        var connectionString = "Server =LHO10068951\\SQLEXPRESS; Database = Library;Integrated Security=SSPI; TrustServerCertificate=True;";
        var connection = new SqlConnection(connectionString);


    }
}