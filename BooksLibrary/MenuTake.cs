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
            Book book;
            if (General.TryGetComboBoxData(comboBoxSelectBooks, out book))
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
                General.ShowMessageAndClear("Книга не найдена!", textBoxAmount);
            }           
        }

        private void MenuTake_Load(object sender, EventArgs e)
        {
            General.AddBooksToComboBox(comboBoxSelectBooks);
        }

        private void comboBoxMenuTake_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book;
            if (General.TryGetComboBoxData(comboBoxSelectBooks, out book) == false)
            {
                General.ShowMessageAndClear("Книга не найдена!", textBoxAmount);
            }
        }
    }
}
