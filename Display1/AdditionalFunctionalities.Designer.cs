namespace Display1
{
    partial class AdditionalFunctionalities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalFunctionalities));
            buttonAdditionalGoBackToMain = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBoxBooksByGenre = new System.Windows.Forms.TextBox();
            textBoxBooksByAuthor = new System.Windows.Forms.TextBox();
            listBoxBooksByGenre = new System.Windows.Forms.ListBox();
            buttonBooksByGenre = new System.Windows.Forms.Button();
            listBoxBooksByAuthor = new System.Windows.Forms.ListBox();
            buttonBooksByAuthor = new System.Windows.Forms.Button();
            listBoxCheapestBook = new System.Windows.Forms.ListBox();
            buttonGetCheapestBook = new System.Windows.Forms.Button();
            dataGridViewAdditional = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdditional).BeginInit();
            SuspendLayout();
            // 
            // buttonAdditionalGoBackToMain
            // 
            buttonAdditionalGoBackToMain.BackColor = System.Drawing.Color.Lavender;
            buttonAdditionalGoBackToMain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAdditionalGoBackToMain.Location = new System.Drawing.Point(10, 439);
            buttonAdditionalGoBackToMain.Name = "buttonAdditionalGoBackToMain";
            buttonAdditionalGoBackToMain.Size = new System.Drawing.Size(778, 35);
            buttonAdditionalGoBackToMain.TabIndex = 0;
            buttonAdditionalGoBackToMain.Text = "Върни се към главната форма";
            buttonAdditionalGoBackToMain.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Controls.Add(textBoxBooksByGenre);
            groupBox1.Controls.Add(textBoxBooksByAuthor);
            groupBox1.Controls.Add(listBoxBooksByGenre);
            groupBox1.Controls.Add(buttonBooksByGenre);
            groupBox1.Controls.Add(listBoxBooksByAuthor);
            groupBox1.Controls.Add(buttonBooksByAuthor);
            groupBox1.Controls.Add(listBoxCheapestBook);
            groupBox1.Controls.Add(buttonGetCheapestBook);
            groupBox1.Location = new System.Drawing.Point(10, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(320, 420);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Допълнителни функционалности";
            // 
            // textBoxBooksByGenre
            // 
            textBoxBooksByGenre.Location = new System.Drawing.Point(9, 327);
            textBoxBooksByGenre.Name = "textBoxBooksByGenre";
            textBoxBooksByGenre.Size = new System.Drawing.Size(296, 23);
            textBoxBooksByGenre.TabIndex = 8;
            // 
            // textBoxBooksByAuthor
            // 
            textBoxBooksByAuthor.Location = new System.Drawing.Point(9, 184);
            textBoxBooksByAuthor.Name = "textBoxBooksByAuthor";
            textBoxBooksByAuthor.Size = new System.Drawing.Size(296, 23);
            textBoxBooksByAuthor.TabIndex = 8;
            // 
            // listBoxBooksByGenre
            // 
            listBoxBooksByGenre.FormattingEnabled = true;
            listBoxBooksByGenre.ItemHeight = 15;
            listBoxBooksByGenre.Location = new System.Drawing.Point(9, 359);
            listBoxBooksByGenre.Name = "listBoxBooksByGenre";
            listBoxBooksByGenre.Size = new System.Drawing.Size(296, 49);
            listBoxBooksByGenre.TabIndex = 7;
            // 
            // buttonBooksByGenre
            // 
            buttonBooksByGenre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonBooksByGenre.Location = new System.Drawing.Point(9, 275);
            buttonBooksByGenre.Name = "buttonBooksByGenre";
            buttonBooksByGenre.Size = new System.Drawing.Size(296, 46);
            buttonBooksByGenre.TabIndex = 6;
            buttonBooksByGenre.Text = "Намери книгите по жанр (въведи жанр)";
            buttonBooksByGenre.UseVisualStyleBackColor = true;
            buttonBooksByGenre.Click += buttonBooksByGenre_Click;
            // 
            // listBoxBooksByAuthor
            // 
            listBoxBooksByAuthor.FormattingEnabled = true;
            listBoxBooksByAuthor.ItemHeight = 15;
            listBoxBooksByAuthor.Location = new System.Drawing.Point(9, 214);
            listBoxBooksByAuthor.Name = "listBoxBooksByAuthor";
            listBoxBooksByAuthor.Size = new System.Drawing.Size(296, 49);
            listBoxBooksByAuthor.TabIndex = 5;
            // 
            // buttonBooksByAuthor
            // 
            buttonBooksByAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonBooksByAuthor.Location = new System.Drawing.Point(9, 132);
            buttonBooksByAuthor.Name = "buttonBooksByAuthor";
            buttonBooksByAuthor.Size = new System.Drawing.Size(296, 46);
            buttonBooksByAuthor.TabIndex = 4;
            buttonBooksByAuthor.Text = "Намери книгите на автор (въведи име)";
            buttonBooksByAuthor.UseVisualStyleBackColor = true;
            buttonBooksByAuthor.Click += buttonBooksByAuthor_Click;
            // 
            // listBoxCheapestBook
            // 
            listBoxCheapestBook.FormattingEnabled = true;
            listBoxCheapestBook.ItemHeight = 15;
            listBoxCheapestBook.Location = new System.Drawing.Point(9, 71);
            listBoxCheapestBook.Name = "listBoxCheapestBook";
            listBoxCheapestBook.Size = new System.Drawing.Size(296, 49);
            listBoxCheapestBook.TabIndex = 3;
            // 
            // buttonGetCheapestBook
            // 
            buttonGetCheapestBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonGetCheapestBook.Location = new System.Drawing.Point(9, 19);
            buttonGetCheapestBook.Name = "buttonGetCheapestBook";
            buttonGetCheapestBook.Size = new System.Drawing.Size(296, 46);
            buttonGetCheapestBook.TabIndex = 0;
            buttonGetCheapestBook.Text = "Намери най-евтината книга";
            buttonGetCheapestBook.UseVisualStyleBackColor = true;
            buttonGetCheapestBook.Click += buttonGetCheapestBook_Click;
            // 
            // dataGridViewAdditional
            // 
            dataGridViewAdditional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdditional.Location = new System.Drawing.Point(336, 13);
            dataGridViewAdditional.Name = "dataGridViewAdditional";
            dataGridViewAdditional.RowTemplate.Height = 25;
            dataGridViewAdditional.Size = new System.Drawing.Size(452, 420);
            dataGridViewAdditional.TabIndex = 2;
            // 
            // AdditionalFunctionalities
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(802, 477);
            Controls.Add(dataGridViewAdditional);
            Controls.Add(groupBox1);
            Controls.Add(buttonAdditionalGoBackToMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "AdditionalFunctionalities";
            Text = "AdditionalFunctionalities";
            Load += AdditionalFunctionalities_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdditional).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonAdditionalGoBackToMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGetCheapestBook;
        private System.Windows.Forms.DataGridView dataGridViewAdditional;
        private System.Windows.Forms.TextBox textBoxBooksByGenre;
        private System.Windows.Forms.TextBox textBoxBooksByAuthor;
        private System.Windows.Forms.ListBox listBoxBooksByGenre;
        private System.Windows.Forms.Button buttonBooksByGenre;
        private System.Windows.Forms.ListBox listBoxBooksByAuthor;
        private System.Windows.Forms.Button buttonBooksByAuthor;
        private System.Windows.Forms.ListBox listBoxCheapestBook;
    }
}