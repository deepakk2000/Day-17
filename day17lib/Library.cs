using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17lib
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        public void ViewAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }

        public void SearchBookById(int id)
        {
            var book = books.Find(b => b.BookId == id);
            if (book != null)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.ToLower() == title.ToLower());
            if (book != null)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }
    }
}
