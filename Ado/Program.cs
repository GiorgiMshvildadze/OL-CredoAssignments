using Microsoft.Data.SqlClient;
using System.Data;

namespace AdonetBookLibrary;

class Program
{
    public static async Task Main()
    {

        var connectionString = "Server =LHO10068951\\SQLEXPRESS; Database = Library;Integrated Security=SSPI; TrustServerCertificate=True;";
        var query = "GetBookByAuthorId";
        //int autId = Int32.Parse(Console.ReadLine());
        var connection = new SqlConnection(connectionString);
        try
        {
            await connection.OpenAsync();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AuthorId", 3);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    var id = reader["BookId"];
                    var title = reader["Title"];
                    var authorId = reader["AuthorId"];
                    var yearPublished = reader["YearPublished"];
                    Console.WriteLine($"Id: {id}  Title: {title}  AuthorId: {authorId}  Year published: {yearPublished}");

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error");
        }
        await connection.CloseAsync();

    }
}
