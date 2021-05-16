using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBookLib
{
    public class CBook : IComparable<CBook>
    {
        //public static List<CBook> Books { get; private set; } = new List<CBook>();
        public static RedBlackTree<CBook> Books { get; private set; } = new RedBlackTree<CBook>();
        private static int _iterator = 1;
        static public int Count
        {
            get
            {
                return Books.Count;
            }
        }
        public int AvailableCopies
        {
            get
            {
                return CopiesAll - CopiesReaders;
            }
        }
        public int Key { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public int Pages { get; private set; }
        public int CopiesAll { get; private set; }
        public int CopiesReaders { get; private set; }

        public CBook()
        {
            Key = 1;
            Key++;
            Books.Add(this);
        }
        public CBook(string name, string author, int pages, int year, int copiesAll, int copiesReaders)
        {
            SetBook(name, author, pages, year, copiesAll, copiesReaders);
            Key = _iterator;
            _iterator++;
            Books.Add(this);
        }
        public CBook(CBook book)
        {
            SetBook(book.Name, book.Author, book.Pages, book.Year, book.CopiesAll, book.CopiesReaders);
            Key = _iterator;
            _iterator++;
            Books.Add(this);
        }
        ~CBook()
        {
            //Count--;
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
                throw new Exception("Неверное значение для взятия книги. Повторите попытку.");

            if (AvailableCopies < amount)
                throw new Exception($"Задано неверное количество книг для взятия. Книг доступно: {AvailableCopies}");

            CopiesReaders += amount;
        }

        public void SetBook(string name, string author, int pages, int year, int copiesAll, int copiesReaders)
        {
            if (copiesReaders > copiesAll)
                throw new Exception("Количество книг на руках, не должно превышать количества книг всего.");
            this.Name = name;
            this.Author = author;
            this.Pages = pages;
            this.Year = year;
            this.CopiesAll = copiesAll;
            this.CopiesReaders = copiesReaders;
            
        }

        public string Info()
        {
            return $"#{Key} Автор: {Author}, название: {Name}, количество страниц: {Pages}, год издания: {Year} г. Книг в библ.:{AvailableCopies}, на руках: {CopiesReaders}\n";
        }

        public void Delete()
        {
            Books.Delete(this);
        }

        public static CBook GetByIndex(int index)
        {
            return Books.Find(b => b.Key.CompareTo(index));
        }

        public static CBook GetByName(string name)
        {
            return Books.Find(book => book.Name.CompareTo(name));
        }



        public int CompareTo(CBook other)
        {
            if (this.Key > other.Key)
                return 1;
            if (this.Key == other.Key)
                return 0;
            return -1;
        }

        public static bool operator >(CBook a, CBook b)
        {
            return a.Pages > b.Pages;
        }

        public static bool operator <(CBook a, CBook b)
        {
            return a.Pages < b.Pages;
        }

        public static bool operator ==(CBook a, CBook b)
        {
            return a.Pages == b.Pages;
        }

        public static bool operator !=(CBook a, CBook b)
        {
            return a.Pages != b.Pages;
        }
    }
}