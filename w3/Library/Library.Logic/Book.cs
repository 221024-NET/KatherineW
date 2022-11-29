using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
    public class Book
    {
        // Fields
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Inventory { get; set; }

        // Constructor
        public Book (){}

        public Book (string title, string author, string iSBN, int inventory)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Inventory = inventory;
        }

        // Methods
    }
}
