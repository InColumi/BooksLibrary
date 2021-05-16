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
    public partial class MenuDelete : Form
    {
        public MenuDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBook book;
            if (comboBoxSelectBook.SelectedItem != null)
            {
                if (General.TryGetComboBoxData(comboBoxSelectBook, out book))
                {
                    try
                    {
                        book.Delete();
                        MessageBox.Show("Книга удалена!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Книга отсутствует!");
                    return;
                }
            }
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            General.AddBooksToComboBox(comboBoxSelectBook);
        }
    }
}
