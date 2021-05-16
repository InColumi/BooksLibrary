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
    public partial class MenuTake : Form
    {
        public MenuTake()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBook book;
            if (General.TryGetComboBoxData(comboBoxSelectBooks, out book))
            {
                try
                {
                    book.TakeBook(hScrollBarAmountBooks.Value);
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
            }           
        }

        private void MenuTake_Load(object sender, EventArgs e)
        {
            General.AddBooksToComboBox(comboBoxSelectBooks);
        }

        private void comboBoxMenuTake_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBook book;
            if (General.TryGetComboBoxData(comboBoxSelectBooks, out book))
            {
                General.UpdateScrollBar(hScrollBarAmountBooks, book.AvailableCopies);
            }
            else
            {
                General.ShowMessageAndClear("Книга не найдена!", labelAmount, hScrollBarAmountBooks);
            }
        }

        private void hScrollBarMenuTake_Scroll(object sender, ScrollEventArgs e)
        {
            labelAmount.Text = hScrollBarAmountBooks.Value.ToString();
        }
    }
}
