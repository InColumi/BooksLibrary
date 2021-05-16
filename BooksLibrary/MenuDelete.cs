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
            Book book;
            if (comboBoxSelectBook.SelectedItem != null)
            {
                if (General.TryGetComboBoxData(comboBoxSelectBook, out book))
                {
                    try
                    {
                        BookList.Delete(book);
                        MessageBox.Show("Книга удалена!");
                        comboBoxSelectBook.Items.Clear();
                        General.AddBooksToComboBox(comboBoxSelectBook);
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
