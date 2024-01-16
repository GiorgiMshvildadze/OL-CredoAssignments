using CleanCode1;
using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BookRepository bookRepository = new BookRepository();

            while (true)
            {
                bookRepository.PrintMenu();
                switch (bookRepository.GetUserChoice())
                {
                    case MenuChoice.AddBook:
                        bookRepository.RemoveBook();
                        break;

                    case MenuChoice.ListllBooks:
                        bookRepository.ListAllBooks();
                        break;

                    case MenuChoice.Exit:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

    }


    public class Library
    {
        Book book = new Book();
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool RemoveBook(string isbn)
        {
            var bookToRemove = books.Find(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                return true;
            }
            return false;
        }

        public List<Book> ListBooks()
        {
            return books;
        }
    }
    public class Book
    {
        public string Title;
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }
}