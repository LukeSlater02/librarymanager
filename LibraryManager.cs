using System;
using System.Collections.Generic;
namespace Library
{
    public class LibraryManager
    {
        public string Name { get; set; }
        private List<Book> _books = new List<Book>();
        public LibraryManager(string n)
        {
            Name = n;
        }

        public void libraryCollection()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine($"{book.Title}, by {book.Author}");
            }
        }

        public void addToCollection(Book book)
        {
            _books.Add(book);
        }
    }
}