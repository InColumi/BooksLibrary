using System;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MenuGetStat : Form
    {
        public MenuGetStat()
        {
            InitializeComponent();
        }

        private void StatsBook_Load(object sender, EventArgs e)
        {
            var books = BookList.Books.List;

            foreach (var bookItem in books)
            {
                comboBoxMenuGetStat.Items.Add(bookItem.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var book = BookList.GetByName(comboBoxMenuGetStat.SelectedItem.ToString());
                if (book is null)
                {
                    MessageBox.Show("Книга не найдена!");
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    return;
                }
                textBox2.Text = book.AvailableCopies.ToString();
                textBox3.Text = book.CopiesAll.ToString();
                textBox4.Text = BookList.Count.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при вводе данных!");
            }
        }
    }
}
