using System;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MenuReturn : Form
    {
        public MenuReturn()
        {
            InitializeComponent();
        }

        private void MenuReturn_Load(object sender, EventArgs e)
        {
            var books = BookList.Books.List;

            foreach (var bookItem in books)
            {
                comboBoxSelectBook.Items.Add(bookItem.Name);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Book book;
            book = null;
            if (comboBoxSelectBook.SelectedItem != null)
            {
                book = BookList.GetByName(comboBoxSelectBook.SelectedItem.ToString());
            }
            if (book is null == false)
            {
                try
                {
                    book.ReturnBook(int.Parse(textBoxAmount.Text));
                    MessageBox.Show($"Книга: {book.ToString()} возвращена.\n" +
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
                return;
            }
        }

        private void comboBoxSelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book;
            book = null;
            if (comboBoxSelectBook.SelectedItem != null)
            {
                book = BookList.GetByName(comboBoxSelectBook.SelectedItem.ToString());
            }
            if (book is null == false)
            {
                MessageBox.Show("Книга не найдена!");
                textBoxAmount.Text = "0";
            }
        }
    }
}
