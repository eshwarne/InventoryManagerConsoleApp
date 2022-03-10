using System;
using System.Collections.Generic;
using InventoryModels;
namespace InventoryManager
{
    public static class InventoryManager
    {
        static Inventory inventory;
        public static Inventory getInventoryManager()
        {
            if(inventory == null)
            {
                inventory = new Inventory();
            }
            return inventory;
        }
        public static Book getBookByISBN(string ISBN) {
            return inventory.BookLookupByISBN.GetValueOrDefault(ISBN, null);
        }
        public static bool addBook(string ISBN, string name, double cost, double discount)
        {
            if(discount > 1.0)
            {
                return false;
            }
            else
            {
                inventory.BookLookupByISBN.Add(ISBN, new Book(ISBN, name, cost, discount));
                return true;
            }
        }
        public static List<Book> getAllBooks()
        {
            return new List<Book>(inventory.BookLookupByISBN.Values);
        }

    
    }
    
}
