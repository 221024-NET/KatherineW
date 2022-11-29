using Library.Data;
using Library.InOut;
using Library.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Library.App
{
    public class Library
    {
        // Fields
        List<User> patrons = new List<User>();
        List<Book> books = new List<Book>();

        IRepository _repo;
        IO _io;

        // Constructor
        public Library(IRepository repo, IO io)
        {
            this._repo = repo;
            this._io = io;
        }

        // Methods

        public void GetInventory()
        {
            IEnumerable<string> Titles = _repo.GetAvailableBooks();
            _io.DisplayAvailableBooks(Titles);

        }
    }
}
