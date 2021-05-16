using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MainManu : Form
    {
       private Random _rand = new Random();
        public MainManu()
        {
            InitializeComponent();
        }

        void RefreshData()
        {
            listBox1.DataSource = BookList.Books.List.Select(b => b.ToString()).ToList();
        }

        private void ShowForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm(new MenuAddNew());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowForm(new MenuDelete());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm(new MenuInfo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowForm(new MenuGetStat());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowForm(new MenuTake());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowForm(new MenuReturn());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowForm(new MenuCompare());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            int failed = 0;
            int all = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(dlg.FileName);
                all = lines.Length;
                foreach (string line in lines)
                {
                    string[] data = line.Split(' ');
                    try
                    {
                        BookList.Add(new Book(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
                    }
                    catch
                    {
                        failed++;
                    }
                }
            }
            MessageBox.Show($"Входных книг: {all}, ошибок: {failed}");
            RefreshData();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dlg.FileName))
                {
                    foreach (var book in BookList.Books.List)
                    {
                        writer.WriteLine(book.ToString());
                    }
                    MessageBox.Show($"Данные записаны в файл: {dlg.FileName}");
                }  
            }      
        }
    }
}
