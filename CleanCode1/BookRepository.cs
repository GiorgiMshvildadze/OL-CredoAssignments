using LibrarySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode1
{
    public class BookRepository
    {
        Library library = new Library();
        public void AddBook()
        {
            Console.WriteLine("Enter book details - Title, Author, ISBN");
            var details = Console.ReadLine().Split(',');
            if (details.Length == 3)
            {
                library.AddBook(new Book(details[0], details[1], details[2]));
                Console.WriteLine("Book added successfully");
            }
            else
            {

                Console.WriteLine("Invalid details");

            }
        }
        public void RemoveBook()
        {
            Console.WriteLine("Enter ISBN of the book to remove"); var isbn = Console.ReadLine();
            if (library.RemoveBook(isbn))
            {
                Console.WriteLine("Book removed successfully");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        public void ListAllBooks()
        {
            var books = library.ListBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }

        public MenuChoice GetUserChoice()
        {
            var choice = (MenuChoice)int.Parse(Console.ReadLine());
            return choice;
        }
       
        public void PrintMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1: Add a book");
            Console.WriteLine("2: Remove a book");
            Console.WriteLine("3: List all books");
            Console.WriteLine("4: Exit");

        }
    }
}
