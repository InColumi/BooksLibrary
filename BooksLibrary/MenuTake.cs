using System;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MenuTake : Form
    {
        public MenuTake()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book;
            book = null;
            if (comboBoxSelectBooks.SelectedItem != null)
            {
                book = BookList.GetByName(comboBoxSelectBooks.SelectedItem.ToString());
            }
            if (book is null == false)
            {
                try
                {
                    book.TakeBook(int.Parse(textBoxAmount.Text));
                    MessageBox.Show($"Книга: {book.ToString()} взята.\n" +
                        $"Осталось {book.AvailableCopies}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Книга не найдена!");
                textBoxAmount.Text = "0";
            }           
        }

        private void MenuTake_Load(object sender, EventArgs e)
        {
            var books = BookList.Books.List;

            foreach (var bookItem in books)
            {
                comboBoxSelectBooks.Items.Add(bookItem.Name);
            }
        }

        private void comboBoxMenuTake_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book;
            book = null;
            if (comboBoxSelectBooks.SelectedItem != null)
            {
                book = BookList.GetByName(comboBoxSelectBooks.SelectedItem.ToString());
            }
            if (book is null == false)
            {
                MessageBox.Show("Книга не найдена!");
                textBoxAmount.Text = "0";
            }
        }
    }
}
