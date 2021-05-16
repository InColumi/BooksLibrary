
namespace BooksLibrary
{
    partial class MenuReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.hScrollBarAmountBooks = new System.Windows.Forms.HScrollBar();
            this.comboBoxSelectBook = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(555, 282);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(97, 33);
            this.buttonReturn.TabIndex = 64;
            this.buttonReturn.Text = "Вернуть";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Оформить возврат книги";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(236, 121);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(18, 20);
            this.labelAmount.TabIndex = 70;
            this.labelAmount.Text = "0";
            // 
            // hScrollBarAmountBooks
            // 
            this.hScrollBarAmountBooks.LargeChange = 1;
            this.hScrollBarAmountBooks.Location = new System.Drawing.Point(26, 155);
            this.hScrollBarAmountBooks.Maximum = 0;
            this.hScrollBarAmountBooks.Name = "hScrollBarAmountBooks";
            this.hScrollBarAmountBooks.Size = new System.Drawing.Size(631, 28);
            this.hScrollBarAmountBooks.TabIndex = 69;
            this.hScrollBarAmountBooks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarAmountBooks_Scroll);
            // 
            // comboBoxSelectBook
            // 
            this.comboBoxSelectBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectBook.FormattingEnabled = true;
            this.comboBoxSelectBook.Location = new System.Drawing.Point(168, 43);
            this.comboBoxSelectBook.Name = "comboBoxSelectBook";
            this.comboBoxSelectBook.Size = new System.Drawing.Size(489, 21);
            this.comboBoxSelectBook.Sorted = true;
            this.comboBoxSelectBook.TabIndex = 68;
            this.comboBoxSelectBook.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectBook_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Количество экземпляров:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Введите количество экземпляров:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Ввеберете книгу:";
            // 
            // MenuReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 329);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.hScrollBarAmountBooks);
            this.Controls.Add(this.comboBoxSelectBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuReturn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuReturn";
            this.Load += new System.EventHandler(this.MenuReturn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.HScrollBar hScrollBarAmountBooks;
        private System.Windows.Forms.ComboBox comboBoxSelectBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}