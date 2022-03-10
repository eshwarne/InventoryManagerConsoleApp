using System;
using System.Collections.Generic;
namespace InventoryModels
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
