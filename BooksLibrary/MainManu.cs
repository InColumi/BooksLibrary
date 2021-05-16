using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CBookLib;

namespace BooksLibrary
{
    public partial class MainManu : Form
    {
        public MainManu()
        {
            InitializeComponent();
            RedBlackTree<int> zx = new RedBlackTree<int>();
            zx.Add(5);
            zx.Add(2);
            zx.Add(8);
            zx.Add(1);
            zx.Add(3);
            zx.Delete(5);
            new CBook("1", "1", 1, 2, 3, 0);
            RefreshData();

        }

        void RefreshData()
        {
            listBox1.DataSource = CBook.Books.List.Select(b => b.Info()).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuAddNew().ShowDialog();
            Show();
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuDelete().ShowDialog();
            Show();
            RefreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuInfo().ShowDialog();
            Show();
            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuGetStat().ShowDialog();
            Show();
            RefreshData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuTake().ShowDialog();
            Show();
            RefreshData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuReturn().ShowDialog();
            Show();
            RefreshData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuCompare().ShowDialog();
            Show();
            RefreshData();
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
                        new CBook(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
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
                string[] lines = new string[CBook.Count];
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = string.Join(" ", new string[] { CBook.Books.List[i].Name, CBook.Books.List[i].Author, CBook.Books.List[i].Pages.ToString(), CBook.Books.List[i].Year.ToString(), CBook.Books.List[i].CopiesAll.ToString(), CBook.Books.List[i].CopiesReaders.ToString() });
                }
                File.WriteAllLines(dlg.FileName, lines);
            }
        }
    }
}
