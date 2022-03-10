using System;
using System.Collections.Generic;
using InventoryModels;
namespace InventoryManager
{
    public class ApplicationShell
    {
        public static void Main(string[] args)
        {
            Inventory inventory = InventoryManager.getInventoryManager();
            while (true)
            {
                Console.WriteLine("1. Add Book \n2. Get Book By ISBN \n3. Get All Books");
                var key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        {
                            Console.WriteLine("Enter Book ISBN");
                            string ISBN = Console.ReadLine();
                            Console.WriteLine("Enter Book Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Book Cost");
                            string cost = Console.ReadLine();
                            Console.WriteLine("Enter Discount Rate (0.0 to 1.0)");
                            string discountRate = Console.ReadLine();
                            InventoryManager.addBook(ISBN, name, double.Parse(cost), double.Parse(discountRate));
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter ISBN");
                            string ISBN = Console.ReadLine();
                            Book foundBook = InventoryManager.getBookByISBN(ISBN);
                            if (foundBook == null)
                            {
                                Console.WriteLine(String.Format("Book with ISBN {0} could not be found", ISBN));
                            }
                            else
                            {
                                Console.WriteLine(foundBook.ToString());
                            }
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Getting All Books");
                            List<Book> books = InventoryManager.getAllBooks();
                            foreach (Book book in books)
                            {
                                Console.WriteLine(book.ToString());
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
            }
        }

    }
}
