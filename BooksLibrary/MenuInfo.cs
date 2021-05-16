using System;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MenuInfo : Form
    {
        public MenuInfo()
        {
            InitializeComponent();
        }

        private void MenuInfo_Load(object sender, EventArgs e)
        {
            var books = BookList.Books.List;

            foreach (var bookItem in books)
            {
                comboBoxSelectBooks.Items.Add(bookItem.Name);
            }
        }

        private void comboBoxSelectBooks_SelectedValueChanged(object sender, EventArgs e)
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
                    textBox2.Text = book.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при вводе данных!");
                }
            }
            else
            {
                MessageBox.Show("Книга не найдена!");
                textBox2.Clear();
            }
        }
    }
}
