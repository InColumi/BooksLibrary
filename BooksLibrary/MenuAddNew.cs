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

namespace BooksLibrary
{
    public partial class MenuAddNew : Form
    {
        public MenuAddNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BookList.Add(new Book( 
                    textBox1.Text,
                    textBox2.Text,
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text),
                    int.Parse(textBox5.Text),
                    int.Parse(textBox6.Text)
                    ));
                MessageBox.Show("Книга добавлена!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
