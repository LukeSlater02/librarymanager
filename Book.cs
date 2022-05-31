using System;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }

        public Book(string t, string a, DateTime pd, string g)
        {
            Title = t;
            Author = a;
            PublishDate = pd;
            Genre = g;
        }

        public override string ToString()
        {
            return $"{Title}, by {Author}";
        }
    }
}