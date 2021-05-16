using System;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MenuDelete : Form
    {
        public MenuDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book;
            if (comboBoxSelectBook.SelectedItem != null)
            {
                book = null;
                if (comboBoxSelectBook.SelectedItem != null)
                {
                    book = BookList.GetByName(comboBoxSelectBook.SelectedItem.ToString());
                }
                if (book is null == false)
                {
                    try
                    {
                        BookList.Delete(book);
                        MessageBox.Show("Книга удалена!");
                        comboBoxSelectBook.Items.Clear();
                        var books = BookList.Books.List;

                        foreach (var bookItem in books)
                        {
                            comboBoxSelectBook.Items.Add(bookItem.Name);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Книга отсутствует!");
                    return;
                }
            }
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            var books = BookList.Books.List;

            foreach (var bookItem in books)
            {
                comboBoxSelectBook.Items.Add(bookItem.Name);
            }
        }
    }
}
