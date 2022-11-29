using Library.Data;
using Library.InOut;
using System;

namespace Library.App
{
    public class Program
    {
        // Fields

        // Constructor

        // Methods
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string ConnectionString = File.ReadAllText(@"/Revature/221024-NET/ConnectionStrings/LibraryConnectionString.txt");

            IRepository repo = new SqlRepository(ConnectionString);
            IO io = new IO();

            Library myLibrary = new Library(repo, io);

            myLibrary.GetInventory();




        }
    }
}
