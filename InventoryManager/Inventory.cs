using System;
using System.Collections.Generic;
namespace InventoryManager
{
    public class Inventory
    {
        public Dictionary<string, Book> BookLookupByISBN { get; set; }
        public Inventory()
        {
            this.BookLookupByISBN = new Dictionary<string, Book>();
        }
    }
}
