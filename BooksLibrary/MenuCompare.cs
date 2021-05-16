using System;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MenuCompare : Form
    {
        public MenuCompare()
        {
            InitializeComponent();
        }

        private void MenuCompare_Load(object sender, EventArgs e)
        {
            var books = BookList.Books.List;

            foreach (var book in books)
            {
                comboBoxFirstBook.Items.Add(book.Name);
            }

            books = BookList.Books.List;

            foreach (var book in books)
            {
                comboBoxSecondBook.Items.Add(book.Name);
            }
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            try
            {
                var book1 = BookList.GetByName(comboBoxFirstBook.SelectedItem.ToString());
                var book2 = BookList.GetByName(comboBoxSecondBook.SelectedItem.ToString());
                if (book1 is null)
                {
                    MessageBox.Show("Книга #1 не найдена!");
                    return;
                }
                if (book2 is null)
                {
                    MessageBox.Show("Книга #2 не найдена!");
                    return;
                }
                if (book1 > book2)
                {
                    MessageBox.Show("Страниц в книге №1 больше, чем в книге №2");
                }
                else
                {
                    if (book1 == book2)
                    {
                        MessageBox.Show("Страниц в книге №1 одинаково, как и в книге №2");
                    }
                    else
                    {
                        MessageBox.Show("Страниц в книге №1 меньше, чем в книге №2");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при вводе данных!");
            }
        }
    }
}
