using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksLibrary.SupportMethods;
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
            General.AddBooksToComboBox(comboBoxFirstBook);
            General.AddBooksToComboBox(comboBoxSecondBook);
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
