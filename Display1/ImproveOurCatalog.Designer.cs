namespace Display1
{
    partial class ImproveOurCatalog
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
            dataGridViewTables = new System.Windows.Forms.DataGridView();
            comboBoxFilter = new System.Windows.Forms.ComboBox();
            groupBoxBook = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            textBoxTitle = new System.Windows.Forms.TextBox();
            textBoxAuthor = new System.Windows.Forms.TextBox();
            textBoxPublishers = new System.Windows.Forms.TextBox();
            textBoxRating = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            textBoxGenre = new System.Windows.Forms.TextBox();
            textBoxISBN = new System.Windows.Forms.TextBox();
            textBoxPublicationYear = new System.Windows.Forms.TextBox();
            dateTimePickerPublicationYear = new System.Windows.Forms.DateTimePicker();
            textBoxLanguage = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
            groupBoxBook.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTables
            // 
            dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTables.Location = new System.Drawing.Point(473, 41);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.RowTemplate.Height = 25;
            dataGridViewTables.Size = new System.Drawing.Size(531, 455);
            dataGridViewTables.TabIndex = 0;
            dataGridViewTables.CellContentClick += dataGridViewTables_CellContentClick;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new System.Drawing.Point(745, 12);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new System.Drawing.Size(259, 23);
            comboBoxFilter.TabIndex = 1;
            // 
            // groupBoxBook
            // 
            groupBoxBook.BackColor = System.Drawing.Color.White;
            groupBoxBook.Controls.Add(btnDelete);
            groupBoxBook.Controls.Add(textBoxLanguage);
            groupBoxBook.Controls.Add(btnUpdate);
            groupBoxBook.Controls.Add(dateTimePickerPublicationYear);
            groupBoxBook.Controls.Add(btnInsert);
            groupBoxBook.Controls.Add(btnSave);
            groupBoxBook.Controls.Add(textBoxPublicationYear);
            groupBoxBook.Controls.Add(textBoxISBN);
            groupBoxBook.Controls.Add(textBoxRating);
            groupBoxBook.Controls.Add(textBoxPrice);
            groupBoxBook.Controls.Add(textBoxGenre);
            groupBoxBook.Controls.Add(textBoxPublishers);
            groupBoxBook.Controls.Add(textBoxAuthor);
            groupBoxBook.Controls.Add(textBoxTitle);
            groupBoxBook.Controls.Add(label9);
            groupBoxBook.Controls.Add(label8);
            groupBoxBook.Controls.Add(label7);
            groupBoxBook.Controls.Add(label6);
            groupBoxBook.Controls.Add(label5);
            groupBoxBook.Controls.Add(label4);
            groupBoxBook.Controls.Add(label3);
            groupBoxBook.Controls.Add(label2);
            groupBoxBook.Controls.Add(label1);
            groupBoxBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxBook.Location = new System.Drawing.Point(12, 12);
            groupBoxBook.Name = "groupBoxBook";
            groupBoxBook.Size = new System.Drawing.Size(440, 484);
            groupBoxBook.TabIndex = 2;
            groupBoxBook.TabStop = false;
            groupBoxBook.Text = "Книги";
            groupBoxBook.Enter += groupBoxBook_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(17, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 22);
            label1.TabIndex = 0;
            label1.Text = "Заглавие: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(17, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 22);
            label2.TabIndex = 1;
            label2.Text = "Автор: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(17, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 22);
            label3.TabIndex = 2;
            label3.Text = "Издателство:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(17, 155);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 22);
            label4.TabIndex = 3;
            label4.Text = "Жанр:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(17, 192);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 22);
            label5.TabIndex = 4;
            label5.Text = "Цена:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(17, 231);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 22);
            label6.TabIndex = 5;
            label6.Text = "Рейтинг: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(17, 271);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(63, 22);
            label7.TabIndex = 6;
            label7.Text = "ISBN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(17, 306);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(94, 44);
            label8.TabIndex = 7;
            label8.Text = "Година на \r\nиздаване: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(17, 363);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(169, 44);
            label9.TabIndex = 8;
            label9.Text = "Оригинален език на \r\nиздаване: ";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new System.Drawing.Point(192, 40);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new System.Drawing.Size(227, 23);
            textBoxTitle.TabIndex = 9;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new System.Drawing.Point(192, 77);
            textBoxAuthor.Multiline = true;
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new System.Drawing.Size(227, 23);
            textBoxAuthor.TabIndex = 10;
            // 
            // textBoxPublishers
            // 
            textBoxPublishers.Location = new System.Drawing.Point(192, 116);
            textBoxPublishers.Multiline = true;
            textBoxPublishers.Name = "textBoxPublishers";
            textBoxPublishers.Size = new System.Drawing.Size(227, 23);
            textBoxPublishers.TabIndex = 11;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new System.Drawing.Point(192, 230);
            textBoxRating.Multiline = true;
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new System.Drawing.Size(227, 23);
            textBoxRating.TabIndex = 14;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(192, 191);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(227, 23);
            textBoxPrice.TabIndex = 13;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new System.Drawing.Point(192, 154);
            textBoxGenre.Multiline = true;
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new System.Drawing.Size(227, 23);
            textBoxGenre.TabIndex = 12;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new System.Drawing.Point(192, 270);
            textBoxISBN.Multiline = true;
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new System.Drawing.Size(227, 23);
            textBoxISBN.TabIndex = 15;
            // 
            // textBoxPublicationYear
            // 
            textBoxPublicationYear.Location = new System.Drawing.Point(192, 299);
            textBoxPublicationYear.Multiline = true;
            textBoxPublicationYear.Name = "textBoxPublicationYear";
            textBoxPublicationYear.Size = new System.Drawing.Size(227, 23);
            textBoxPublicationYear.TabIndex = 16;
            // 
            // dateTimePickerPublicationYear
            // 
            dateTimePickerPublicationYear.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerPublicationYear.CustomFormat = "yyyy";
            dateTimePickerPublicationYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerPublicationYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerPublicationYear.Location = new System.Drawing.Point(192, 325);
            dateTimePickerPublicationYear.Name = "dateTimePickerPublicationYear";
            dateTimePickerPublicationYear.ShowUpDown = true;
            dateTimePickerPublicationYear.Size = new System.Drawing.Size(227, 29);
            dateTimePickerPublicationYear.TabIndex = 17;
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Location = new System.Drawing.Point(192, 372);
            textBoxLanguage.Multiline = true;
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new System.Drawing.Size(227, 23);
            textBoxLanguage.TabIndex = 18;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(17, 420);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(128, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(154, 420);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(128, 43);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(291, 420);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(128, 43);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(154, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(128, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // ImproveOurCatalog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(1016, 508);
            Controls.Add(groupBoxBook);
            Controls.Add(comboBoxFilter);
            Controls.Add(dataGridViewTables);
            Name = "ImproveOurCatalog";
            Text = "ImproveOurCatalog";
            Load += ImproveOurCatalog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).EndInit();
            groupBoxBook.ResumeLayout(false);
            groupBoxBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPublishers;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxPublicationYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublicationYear;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSave;
    }
}