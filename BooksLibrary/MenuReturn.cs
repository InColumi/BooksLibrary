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

        private void hScrollBarAmountBooks_Scroll(object sender, ScrollEventArgs e)
        {
            labelAmount.Text = hScrollBarAmountBooks.Value.ToString();
        }

        private void MenuReturn_Load(object sender, EventArgs e)
        {
            General.AddBooksToComboBox(comboBoxSelectBook);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            CBook book;
            if (General.TryGetComboBoxData(comboBoxSelectBook, out book))
            {
                try
                {
                    book.ReturnBook(hScrollBarAmountBooks.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                General.UpdateScrollBar(hScrollBarAmountBooks, book.AvailableCopies);
            }
            else
            {
                General.ShowMessageAndClear("Книга не найдена!", labelAmount, hScrollBarAmountBooks);
                return;
            }
        }

        private void comboBoxSelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBook book;
            if (General.TryGetComboBoxData(comboBoxSelectBook, out book))
            {
                General.UpdateScrollBar(hScrollBarAmountBooks, book.AvailableCopies);
            }
            else
            {
                General.ShowMessageAndClear("Книга не найдена!", labelAmount, hScrollBarAmountBooks);
                return;
            }
        }
    }
}
