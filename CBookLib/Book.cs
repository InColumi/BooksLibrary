using System;

namespace CBookLib
{
    public class Book : IComparable<Book>
    {
        public int AvailableCopies => CopiesAll - CopiesReaders;
        public int Year { get; private set; }
        public int Pages { get; private set; }
        public int CopiesAll { get; private set; }
        public int CopiesReaders { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }

        public Book()
        {
            SetBook(string.Empty, string.Empty, 0, 0, 0, 0);
        }
        public Book(string name, string author, int pages, int year, int copiesAll, int copiesReaders)
        {
            SetBook(name, author, pages, year, copiesAll, copiesReaders);
        }
        public Book(Book book)
        {
            SetBook(book.Name, book.Author, book.Pages, book.Year, book.CopiesAll, book.CopiesReaders);
        }

        public void ReturnBook(int amount = 1)
        {
            if (amount <= 0)
                throw new Exception("Неверное значение для возврата книги. Повторите попытку.");

            if (CopiesReaders < amount)
                throw new Exception($"Задано неверное количество книг для возврата. Книг на руках у читателей: {CopiesReaders}");

            CopiesReaders -= amount;
        }

        public void TakeBook(int amount = 1)
        {
            if (amount <= 0)
            {
                throw new Exception("Неверное значение для взятия книги. Повторите попытку.");
            }

            if (AvailableCopies < amount)
            {
                throw new Exception($"Задано неверное количество книг для взятия. Книг доступно: {AvailableCopies}");
            }

            CopiesReaders += amount;
        }

        public void SetBook(string name, string author, int pages, int year, int copiesAll, int copiesReaders)
        {
            if (copiesReaders > copiesAll)
            {
                throw new Exception("Количество книг на руках, не должно превышать количества книг всего.");
            }
            Name = name;
            Author = author;
            Pages = pages;
            Year = year;
            CopiesAll = copiesAll;
            CopiesReaders = copiesReaders;
        }

        public static bool operator >(Book a, Book b)
        {
            return a.Pages > b.Pages;
        }

        public static bool operator <(Book a, Book b)
        {
            return a.Pages < b.Pages;
        }

        public static bool operator ==(Book a, Book b)
        {
            return a.Pages == b.Pages;
        }

        public static bool operator !=(Book a, Book b)
        {
            return a.Pages != b.Pages;
        }

        public override string ToString()
        {
            return $"Автор: {Author}, название: {Name}, количество страниц: {Pages}, год издания: {Year} г. Книг в библ.:{AvailableCopies}, на руках: {CopiesReaders}"; ;
        }

        public int CompareTo(Book book)
        { 
            return Name.CompareTo(book.Name);
        }
    }
}
