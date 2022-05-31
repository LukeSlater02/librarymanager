using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager edgelordLibrary = new LibraryManager("Edgelord Library Inc");
            Book blackCompany = new Book("The Black Company", "Glen Cook", new DateTime(1984, 5, 15), "Dark fantasy");
            List<Book> bookList = new List<Book>()
            {
                new Book("Elric of Melniboné", "Michael Moorcock", new DateTime(1972, 7, 21), "Fantasy Fiction"),
                new Book("Dreams of Steel", "Glen Cook", new DateTime(1985, 4, 15), "Dark fantasy"),
                new Book("Thief", "Matthew Colville", new DateTime(2014, 3, 11), "Fantasy hardboiled")
            };
            bookList.Add(blackCompany);

            Console.WriteLine($"Welcome to the {edgelordLibrary.Name} Library Mangement System");
            foreach(Book book in bookList){
                edgelordLibrary.addToCollection(book);
            }

            edgelordLibrary.libraryCollection();
        }
    }
}
