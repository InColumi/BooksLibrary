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
    public partial class MenuInfo : Form
    {
        public MenuInfo()
        {
            InitializeComponent();
        }

        private void MenuInfo_Load(object sender, EventArgs e)
        {
            General.AddBooksToComboBox(comboBoxSelectBooks);
        }

        private void comboBoxSelectBooks_SelectedValueChanged(object sender, EventArgs e)
        {
            Book book;
            if (General.TryGetComboBoxData(comboBoxSelectBooks, out book))
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
