using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day17lib;

namespace Day17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nChoose:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book newBook = new Book();
                        Console.WriteLine("Enter Book ID:");
                        newBook.BookId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Title:");
                        newBook.Title = Console.ReadLine();
                        Console.WriteLine("Enter Author:");
                        newBook.Author = Console.ReadLine();
                        Console.WriteLine("Enter Genre:");
                        newBook.Genre = Console.ReadLine();
                        Console.WriteLine("Is the book available? (true/false):");
                        newBook.IsAvailable = bool.Parse(Console.ReadLine());
                        library.AddBook(newBook);
                        break;
                    case 2:
                        library.ViewAllBooks();
                        break;
                    case 3:
                        Console.WriteLine("Enter Book ID to search:");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;
                    case 4:
                        Console.WriteLine("Enter Title to search:");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }

        }
    }
}
