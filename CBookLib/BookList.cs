using System;

namespace CBookLib
{
    public static class BookList
    {
        public static RedBlackTree<Book> Books { get; private set; }
        public static int Count => Books.Count;

        static BookList()
        {
            Books = new RedBlackTree<Book>();
        }

        public static void Delete(Book book)
        {
            Books.Delete(book);
        }

        public static void Add(Book book)
        {
            Books.Add(book);
        }

        public static Book GetByName(string name)
        {
            return Books.Find(book => book.Name.CompareTo(name));
        }
    }
}