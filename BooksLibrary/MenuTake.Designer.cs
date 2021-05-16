
namespace BooksLibrary
{
    partial class MenuTake
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
            this.buttonTake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSelectBooks = new System.Windows.Forms.ComboBox();
            this.hScrollBarAmountBooks = new System.Windows.Forms.HScrollBar();
            this.labelAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(554, 274);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(97, 33);
            this.buttonTake.TabIndex = 50;
            this.buttonTake.Text = "Получить";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ввеберете книгу:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Оформить получение книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Введите количество экземпляров:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Количество экземпляров:";
            // 
            // comboBoxSelectBooks
            // 
            this.comboBoxSelectBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectBooks.FormattingEnabled = true;
            this.comboBoxSelectBooks.Location = new System.Drawing.Point(160, 47);
            this.comboBoxSelectBooks.Name = "comboBoxSelectBooks";
            this.comboBoxSelectBooks.Size = new System.Drawing.Size(489, 21);
            this.comboBoxSelectBooks.Sorted = true;
            this.comboBoxSelectBooks.TabIndex = 62;
            this.comboBoxSelectBooks.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenuTake_SelectedIndexChanged);
            // 
            // hScrollBarAmountBooks
            // 
            this.hScrollBarAmountBooks.LargeChange = 1;
            this.hScrollBarAmountBooks.Location = new System.Drawing.Point(18, 159);
            this.hScrollBarAmountBooks.Maximum = 0;
            this.hScrollBarAmountBooks.Name = "hScrollBarAmountBooks";
            this.hScrollBarAmountBooks.Size = new System.Drawing.Size(631, 28);
            this.hScrollBarAmountBooks.TabIndex = 63;
            this.hScrollBarAmountBooks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarMenuTake_Scroll);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(228, 125);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(18, 20);
            this.labelAmount.TabIndex = 64;
            this.labelAmount.Text = "0";
            // 
            // MenuTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 315);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.hScrollBarAmountBooks);
            this.Controls.Add(this.comboBoxSelectBooks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuTake";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " MenuTake";
            this.Load += new System.EventHandler(this.MenuTake_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSelectBooks;
        private System.Windows.Forms.HScrollBar hScrollBarAmountBooks;
        private System.Windows.Forms.Label labelAmount;
    }
}