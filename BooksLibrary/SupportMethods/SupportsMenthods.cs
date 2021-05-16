using CBookLib;
using System.Windows.Forms;

namespace BooksLibrary.SupportMethods
{
    static class General
    {
        /// <summary>
        /// Добавляет в ComboBox книги из класса CBook
        /// </summary>
        /// <param name="box"></param>
        public static void AddBooksToComboBox(ComboBox box)
        {
            var books = CBook.Books.List;

            foreach (var book in books)
            {
                box.Items.Add(book.Name);
            }
        }

        /// <summary>
        /// Обновляет значение scrollBar на value
        /// </summary>
        /// <param name="scrollBar"></param>
        /// <param name="value"></param>
        public static void UpdateScrollBar(HScrollBar scrollBar, int value)
        {
            scrollBar.Minimum = 0;
            scrollBar.Maximum = value;
        }

        /// <summary>
        /// Пробует получить данные из box
        /// </summary>
        /// <param name="box"></param>
        /// <param name="book"></param>
        /// <returns> если не null вернет значение</returns>
        public static bool TryGetComboBoxData(ComboBox box, out CBook book)
        {
            book = null;
            if (box.SelectedItem != null)
            {
                book = CBook.GetByName(box.SelectedItem.ToString());
            }            
            return book is null == false;
        }

        /// <summary>
        /// Выводит сообщение message и очищает label, bar
        /// </summary>
        /// <param name="message"></param>
        /// <param name="label"></param>
        /// <param name="bar"></param>
        public static void ShowMessageAndClear(string message, Label label, HScrollBar bar)
        {
            MessageBox.Show(message);
            label.Text = "0";
            bar.Maximum = 0;
        }
    }
}
