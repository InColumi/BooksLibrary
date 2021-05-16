using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CBookLib;
using BooksLibrary.SupportMethods;

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
            General.AddBooksToComboBox(comboBoxMenuGetStat);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var book = CBook.GetByName(comboBoxMenuGetStat.SelectedItem.ToString());
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
                textBox4.Text = CBook.Count.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при вводе данных!");
            }
        }
    }
}
