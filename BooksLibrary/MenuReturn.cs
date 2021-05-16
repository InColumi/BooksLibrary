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
    public partial class MenuReturn : Form
    {
        public MenuReturn()
        {
            InitializeComponent();
        }

        private void MenuReturn_Load(object sender, EventArgs e)
        {
            General.AddBooksToComboBox(comboBoxSelectBook);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Book book;
            if (General.TryGetComboBoxData(comboBoxSelectBook, out book))
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
                General.ShowMessageAndClear("Книга не найдена!", textBoxAmount);
                return;
            }
        }

        private void comboBoxSelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book;
            if (General.TryGetComboBoxData(comboBoxSelectBook, out book) == false)
            {
                General.ShowMessageAndClear("Книга не найдена!", textBoxAmount);
            }
        }
    }
}
