using Library.Logic;
using System.Data.SqlClient;

namespace Library.Data
{
    public class SqlRepository : IRepository
    {
        // Fields
        private string _connectionString;

        // Constructors
        public SqlRepository(string connectionString) 
        {
            this._connectionString = connectionString;
        }

        // Methods
        public IEnumerable<string> GetAvailableBooks()
        {
            List<string> Titles = new List<string>();

            using SqlConnection connection = new SqlConnection(this._connectionString);

            connection.Open();

            string cmdText = "SELECT Title, Inventory - COUNT(Title) AS 'Available' " +
                                "FROM Library.Books " +
                                "JOIN Library.Checkout " +
                                "ON Library.Books.ISBN = Library.Checkout.ISBN " +
                                "WHERE ReturnDate IS NULL " +
                                "GROUP BY Title, Inventory " +
                                "HAVING (Inventory - COUNT(Title)) > 0;";

            using SqlCommand cmd = new SqlCommand(cmdText, connection);

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Titles.Add(reader.GetString(0));
            }

            connection.Close();
            return Titles;
        }
    }
}