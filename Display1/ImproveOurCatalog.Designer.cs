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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImproveOurCatalog));
            dataGridViewTables = new System.Windows.Forms.DataGridView();
            comboBoxFilter = new System.Windows.Forms.ComboBox();
            groupBoxBook = new System.Windows.Forms.GroupBox();
            label15 = new System.Windows.Forms.Label();
            textBoxPages = new System.Windows.Forms.TextBox();
            textBoxNationalityNameBook = new System.Windows.Forms.TextBox();
            buttonDeleteBook = new System.Windows.Forms.Button();
            textBoxLanguage = new System.Windows.Forms.TextBox();
            buttonUpdateBook = new System.Windows.Forms.Button();
            buttonInsertBook = new System.Windows.Forms.Button();
            buttonSaveBook = new System.Windows.Forms.Button();
            textBoxPublicationYear = new System.Windows.Forms.TextBox();
            textBoxISBN = new System.Windows.Forms.TextBox();
            textBoxRating = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            textBoxGenre = new System.Windows.Forms.TextBox();
            textBoxPublishers = new System.Windows.Forms.TextBox();
            textBoxAuthor = new System.Windows.Forms.TextBox();
            textBoxTitle = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBoxNationality = new System.Windows.Forms.GroupBox();
            pictureBoxNationality = new System.Windows.Forms.PictureBox();
            buttonDeleteNationality = new System.Windows.Forms.Button();
            buttonUpdateNationality = new System.Windows.Forms.Button();
            buttonInsertNationality = new System.Windows.Forms.Button();
            buttonSaveNationality = new System.Windows.Forms.Button();
            textBoxNameNationality = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            dateTimePickerPublicationYear = new System.Windows.Forms.DateTimePicker();
            groupBoxGenre = new System.Windows.Forms.GroupBox();
            pictureBoxGenre = new System.Windows.Forms.PictureBox();
            buttonDeleteGenre = new System.Windows.Forms.Button();
            buttonUpdateGenre = new System.Windows.Forms.Button();
            buttonInsertGenre = new System.Windows.Forms.Button();
            buttonSaveGenre = new System.Windows.Forms.Button();
            textBoxGenreName = new System.Windows.Forms.TextBox();
            label = new System.Windows.Forms.Label();
            groupBoxLanguage = new System.Windows.Forms.GroupBox();
            pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            buttonDeleteLanguage = new System.Windows.Forms.Button();
            buttonUpdateLanguage = new System.Windows.Forms.Button();
            buttonInsertLanguage = new System.Windows.Forms.Button();
            buttonSaveLanguage = new System.Windows.Forms.Button();
            textBoxCodeLanguage = new System.Windows.Forms.TextBox();
            textBoxNameLanguage = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            groupBoxPublisher = new System.Windows.Forms.GroupBox();
            pictureBoxPublisher = new System.Windows.Forms.PictureBox();
            buttonDeletePublisher = new System.Windows.Forms.Button();
            buttonUpdatePublisher = new System.Windows.Forms.Button();
            buttonInsertPublisher = new System.Windows.Forms.Button();
            buttonSavePublisher = new System.Windows.Forms.Button();
            textBoxNamePublisher = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            btnGoBackToMainForm = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            textBoxAuthorName = new System.Windows.Forms.TextBox();
            buttonSaveAuthor = new System.Windows.Forms.Button();
            buttonInsertAuthor = new System.Windows.Forms.Button();
            buttonUpdateAuthor = new System.Windows.Forms.Button();
            buttonDeleteAuthor = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label14 = new System.Windows.Forms.Label();
            textBoxAuthorNationality = new System.Windows.Forms.TextBox();
            groupBoxAuthors = new System.Windows.Forms.GroupBox();
            buttonInsertData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
            groupBoxBook.SuspendLayout();
            groupBoxNationality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNationality).BeginInit();
            groupBoxGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenre).BeginInit();
            groupBoxLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLanguage).BeginInit();
            groupBoxPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublisher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxAuthors.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTables
            // 
            dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTables.Location = new System.Drawing.Point(473, 41);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.RowTemplate.Height = 25;
            dataGridViewTables.Size = new System.Drawing.Size(531, 394);
            dataGridViewTables.TabIndex = 0;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Книги", "Жанрове", "Националности", "Автори", "Езици", "Издателства" });
            comboBoxFilter.Location = new System.Drawing.Point(745, 12);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new System.Drawing.Size(259, 23);
            comboBoxFilter.TabIndex = 1;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged_1;
            // 
            // groupBoxBook
            // 
            groupBoxBook.BackColor = System.Drawing.Color.White;
            groupBoxBook.Controls.Add(label15);
            groupBoxBook.Controls.Add(textBoxPages);
            groupBoxBook.Controls.Add(textBoxNationalityNameBook);
            groupBoxBook.Controls.Add(buttonDeleteBook);
            groupBoxBook.Controls.Add(textBoxLanguage);
            groupBoxBook.Controls.Add(buttonUpdateBook);
            groupBoxBook.Controls.Add(buttonInsertBook);
            groupBoxBook.Controls.Add(buttonSaveBook);
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
            groupBoxBook.Size = new System.Drawing.Size(440, 485);
            groupBoxBook.TabIndex = 12;
            groupBoxBook.TabStop = false;
            groupBoxBook.Text = "Книги";
            groupBoxBook.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(17, 288);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(90, 22);
            label15.TabIndex = 21;
            label15.Text = "Страници:";
            // 
            // textBoxPages
            // 
            textBoxPages.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPages.Location = new System.Drawing.Point(192, 288);
            textBoxPages.Multiline = true;
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new System.Drawing.Size(227, 23);
            textBoxPages.TabIndex = 20;
            // 
            // textBoxNationalityNameBook
            // 
            textBoxNationalityNameBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxNationalityNameBook.Location = new System.Drawing.Point(83, 77);
            textBoxNationalityNameBook.Multiline = true;
            textBoxNationalityNameBook.Name = "textBoxNationalityNameBook";
            textBoxNationalityNameBook.Size = new System.Drawing.Size(103, 23);
            textBoxNationalityNameBook.TabIndex = 19;
            textBoxNationalityNameBook.TextChanged += textBox1_TextChanged;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Location = new System.Drawing.Point(17, 420);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new System.Drawing.Size(128, 43);
            buttonDeleteBook.TabIndex = 9;
            buttonDeleteBook.Text = "Delete";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            buttonDeleteBook.Click += btnDeleteBook_Click;
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxLanguage.Location = new System.Drawing.Point(192, 372);
            textBoxLanguage.Multiline = true;
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new System.Drawing.Size(227, 23);
            textBoxLanguage.TabIndex = 18;
            // 
            // buttonUpdateBook
            // 
            buttonUpdateBook.Location = new System.Drawing.Point(154, 420);
            buttonUpdateBook.Name = "buttonUpdateBook";
            buttonUpdateBook.Size = new System.Drawing.Size(128, 43);
            buttonUpdateBook.TabIndex = 7;
            buttonUpdateBook.Text = "Update";
            buttonUpdateBook.UseVisualStyleBackColor = true;
            buttonUpdateBook.Click += buttonUpdateBook_Click;
            // 
            // buttonInsertBook
            // 
            buttonInsertBook.Location = new System.Drawing.Point(291, 420);
            buttonInsertBook.Name = "buttonInsertBook";
            buttonInsertBook.Size = new System.Drawing.Size(128, 43);
            buttonInsertBook.TabIndex = 6;
            buttonInsertBook.Text = "Insert";
            buttonInsertBook.UseVisualStyleBackColor = true;
            buttonInsertBook.Click += buttonInsertBook_Click;
            // 
            // buttonSaveBook
            // 
            buttonSaveBook.Location = new System.Drawing.Point(154, 420);
            buttonSaveBook.Name = "buttonSaveBook";
            buttonSaveBook.Size = new System.Drawing.Size(128, 43);
            buttonSaveBook.TabIndex = 8;
            buttonSaveBook.Text = "Save";
            buttonSaveBook.UseVisualStyleBackColor = true;
            buttonSaveBook.Click += buttonSaveBook_Click;
            // 
            // textBoxPublicationYear
            // 
            textBoxPublicationYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPublicationYear.Location = new System.Drawing.Point(192, 327);
            textBoxPublicationYear.Multiline = true;
            textBoxPublicationYear.Name = "textBoxPublicationYear";
            textBoxPublicationYear.Size = new System.Drawing.Size(227, 23);
            textBoxPublicationYear.TabIndex = 16;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxISBN.Location = new System.Drawing.Point(192, 259);
            textBoxISBN.Multiline = true;
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new System.Drawing.Size(227, 23);
            textBoxISBN.TabIndex = 15;
            // 
            // textBoxRating
            // 
            textBoxRating.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxRating.Location = new System.Drawing.Point(192, 230);
            textBoxRating.Multiline = true;
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new System.Drawing.Size(227, 23);
            textBoxRating.TabIndex = 14;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPrice.Location = new System.Drawing.Point(192, 191);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(227, 23);
            textBoxPrice.TabIndex = 13;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxGenre.Location = new System.Drawing.Point(192, 154);
            textBoxGenre.Multiline = true;
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new System.Drawing.Size(227, 23);
            textBoxGenre.TabIndex = 12;
            // 
            // textBoxPublishers
            // 
            textBoxPublishers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPublishers.Location = new System.Drawing.Point(192, 116);
            textBoxPublishers.Multiline = true;
            textBoxPublishers.Name = "textBoxPublishers";
            textBoxPublishers.Size = new System.Drawing.Size(227, 23);
            textBoxPublishers.TabIndex = 11;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxAuthor.Location = new System.Drawing.Point(192, 77);
            textBoxAuthor.Multiline = true;
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new System.Drawing.Size(227, 23);
            textBoxAuthor.TabIndex = 10;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxTitle.Location = new System.Drawing.Point(192, 40);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new System.Drawing.Size(227, 23);
            textBoxTitle.TabIndex = 9;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(17, 260);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(63, 22);
            label7.TabIndex = 6;
            label7.Text = "ISBN:";
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
            // groupBoxNationality
            // 
            groupBoxNationality.BackColor = System.Drawing.Color.White;
            groupBoxNationality.Controls.Add(pictureBoxNationality);
            groupBoxNationality.Controls.Add(buttonDeleteNationality);
            groupBoxNationality.Controls.Add(buttonUpdateNationality);
            groupBoxNationality.Controls.Add(buttonInsertNationality);
            groupBoxNationality.Controls.Add(buttonSaveNationality);
            groupBoxNationality.Controls.Add(textBoxNameNationality);
            groupBoxNationality.Controls.Add(label16);
            groupBoxNationality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxNationality.Location = new System.Drawing.Point(473, 46);
            groupBoxNationality.Name = "groupBoxNationality";
            groupBoxNationality.Size = new System.Drawing.Size(201, 50);
            groupBoxNationality.TabIndex = 7;
            groupBoxNationality.TabStop = false;
            groupBoxNationality.Text = "Националности";
            groupBoxNationality.Visible = false;
            // 
            // pictureBoxNationality
            // 
            pictureBoxNationality.Image = (System.Drawing.Image)resources.GetObject("pictureBoxNationality.Image");
            pictureBoxNationality.Location = new System.Drawing.Point(18, 137);
            pictureBoxNationality.Name = "pictureBoxNationality";
            pictureBoxNationality.Size = new System.Drawing.Size(402, 240);
            pictureBoxNationality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxNationality.TabIndex = 10;
            pictureBoxNationality.TabStop = false;
            // 
            // buttonDeleteNationality
            // 
            buttonDeleteNationality.Location = new System.Drawing.Point(17, 423);
            buttonDeleteNationality.Name = "buttonDeleteNationality";
            buttonDeleteNationality.Size = new System.Drawing.Size(128, 43);
            buttonDeleteNationality.TabIndex = 9;
            buttonDeleteNationality.Text = "Delete";
            buttonDeleteNationality.UseVisualStyleBackColor = true;
            buttonDeleteNationality.Click += buttonDeleteNationality_Click;
            // 
            // buttonUpdateNationality
            // 
            buttonUpdateNationality.Location = new System.Drawing.Point(151, 421);
            buttonUpdateNationality.Name = "buttonUpdateNationality";
            buttonUpdateNationality.Size = new System.Drawing.Size(128, 43);
            buttonUpdateNationality.TabIndex = 7;
            buttonUpdateNationality.Text = "Update";
            buttonUpdateNationality.UseVisualStyleBackColor = true;
            buttonUpdateNationality.Click += buttonUpdateNationality_Click;
            // 
            // buttonInsertNationality
            // 
            buttonInsertNationality.Location = new System.Drawing.Point(291, 423);
            buttonInsertNationality.Name = "buttonInsertNationality";
            buttonInsertNationality.Size = new System.Drawing.Size(128, 43);
            buttonInsertNationality.TabIndex = 6;
            buttonInsertNationality.Text = "Insert";
            buttonInsertNationality.UseVisualStyleBackColor = true;
            buttonInsertNationality.Click += buttonInsertNationality_Click;
            // 
            // buttonSaveNationality
            // 
            buttonSaveNationality.Location = new System.Drawing.Point(151, 421);
            buttonSaveNationality.Name = "buttonSaveNationality";
            buttonSaveNationality.Size = new System.Drawing.Size(128, 43);
            buttonSaveNationality.TabIndex = 8;
            buttonSaveNationality.Text = "Save";
            buttonSaveNationality.UseVisualStyleBackColor = true;
            buttonSaveNationality.Click += buttonSaveNationality_Click;
            // 
            // textBoxNameNationality
            // 
            textBoxNameNationality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxNameNationality.Location = new System.Drawing.Point(150, 67);
            textBoxNameNationality.Multiline = true;
            textBoxNameNationality.Name = "textBoxNameNationality";
            textBoxNameNationality.Size = new System.Drawing.Size(269, 23);
            textBoxNameNationality.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(17, 67);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(127, 22);
            label16.TabIndex = 0;
            label16.Text = "Националност:";
            // 
            // dateTimePickerPublicationYear
            // 
            dateTimePickerPublicationYear.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerPublicationYear.CustomFormat = "yyyy";
            dateTimePickerPublicationYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerPublicationYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerPublicationYear.Location = new System.Drawing.Point(659, 363);
            dateTimePickerPublicationYear.Name = "dateTimePickerPublicationYear";
            dateTimePickerPublicationYear.ShowUpDown = true;
            dateTimePickerPublicationYear.Size = new System.Drawing.Size(227, 29);
            dateTimePickerPublicationYear.TabIndex = 17;
            // 
            // groupBoxGenre
            // 
            groupBoxGenre.BackColor = System.Drawing.Color.White;
            groupBoxGenre.Controls.Add(pictureBoxGenre);
            groupBoxGenre.Controls.Add(buttonDeleteGenre);
            groupBoxGenre.Controls.Add(buttonUpdateGenre);
            groupBoxGenre.Controls.Add(buttonInsertGenre);
            groupBoxGenre.Controls.Add(buttonSaveGenre);
            groupBoxGenre.Controls.Add(textBoxGenreName);
            groupBoxGenre.Controls.Add(label);
            groupBoxGenre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxGenre.Location = new System.Drawing.Point(473, 203);
            groupBoxGenre.Name = "groupBoxGenre";
            groupBoxGenre.Size = new System.Drawing.Size(149, 53);
            groupBoxGenre.TabIndex = 3;
            groupBoxGenre.TabStop = false;
            groupBoxGenre.Text = "Жанрове";
            groupBoxGenre.Visible = false;
            // 
            // pictureBoxGenre
            // 
            pictureBoxGenre.Image = (System.Drawing.Image)resources.GetObject("pictureBoxGenre.Image");
            pictureBoxGenre.Location = new System.Drawing.Point(17, 105);
            pictureBoxGenre.Name = "pictureBoxGenre";
            pictureBoxGenre.Size = new System.Drawing.Size(402, 240);
            pictureBoxGenre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxGenre.TabIndex = 10;
            pictureBoxGenre.TabStop = false;
            // 
            // buttonDeleteGenre
            // 
            buttonDeleteGenre.Location = new System.Drawing.Point(17, 391);
            buttonDeleteGenre.Name = "buttonDeleteGenre";
            buttonDeleteGenre.Size = new System.Drawing.Size(128, 43);
            buttonDeleteGenre.TabIndex = 9;
            buttonDeleteGenre.Text = "Delete";
            buttonDeleteGenre.UseVisualStyleBackColor = true;
            buttonDeleteGenre.Click += buttonDeleteGenre_Click;
            // 
            // buttonUpdateGenre
            // 
            buttonUpdateGenre.Location = new System.Drawing.Point(154, 391);
            buttonUpdateGenre.Name = "buttonUpdateGenre";
            buttonUpdateGenre.Size = new System.Drawing.Size(128, 43);
            buttonUpdateGenre.TabIndex = 7;
            buttonUpdateGenre.Text = "Update";
            buttonUpdateGenre.UseVisualStyleBackColor = true;
            buttonUpdateGenre.Click += buttonUpdateGenre_Click_1;
            // 
            // buttonInsertGenre
            // 
            buttonInsertGenre.Location = new System.Drawing.Point(291, 391);
            buttonInsertGenre.Name = "buttonInsertGenre";
            buttonInsertGenre.Size = new System.Drawing.Size(128, 43);
            buttonInsertGenre.TabIndex = 6;
            buttonInsertGenre.Text = "Insert";
            buttonInsertGenre.UseVisualStyleBackColor = true;
            buttonInsertGenre.Click += buttonInsertGenre_Click;
            // 
            // buttonSaveGenre
            // 
            buttonSaveGenre.Location = new System.Drawing.Point(154, 391);
            buttonSaveGenre.Name = "buttonSaveGenre";
            buttonSaveGenre.Size = new System.Drawing.Size(128, 43);
            buttonSaveGenre.TabIndex = 8;
            buttonSaveGenre.Text = "Save";
            buttonSaveGenre.UseVisualStyleBackColor = true;
            buttonSaveGenre.Click += buttonSaveGenre_Click;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxGenreName.Location = new System.Drawing.Point(79, 52);
            textBoxGenreName.Multiline = true;
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new System.Drawing.Size(340, 23);
            textBoxGenreName.TabIndex = 9;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(17, 52);
            label.Name = "label";
            label.Size = new System.Drawing.Size(56, 22);
            label.TabIndex = 0;
            label.Text = "Жанр:";
            // 
            // groupBoxLanguage
            // 
            groupBoxLanguage.BackColor = System.Drawing.Color.White;
            groupBoxLanguage.Controls.Add(pictureBoxLanguage);
            groupBoxLanguage.Controls.Add(buttonDeleteLanguage);
            groupBoxLanguage.Controls.Add(buttonUpdateLanguage);
            groupBoxLanguage.Controls.Add(buttonInsertLanguage);
            groupBoxLanguage.Controls.Add(buttonSaveLanguage);
            groupBoxLanguage.Controls.Add(textBoxCodeLanguage);
            groupBoxLanguage.Controls.Add(textBoxNameLanguage);
            groupBoxLanguage.Controls.Add(label11);
            groupBoxLanguage.Controls.Add(label10);
            groupBoxLanguage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxLanguage.Location = new System.Drawing.Point(473, 102);
            groupBoxLanguage.Name = "groupBoxLanguage";
            groupBoxLanguage.Size = new System.Drawing.Size(93, 39);
            groupBoxLanguage.TabIndex = 4;
            groupBoxLanguage.TabStop = false;
            groupBoxLanguage.Text = "Езици";
            groupBoxLanguage.Visible = false;
            // 
            // pictureBoxLanguage
            // 
            pictureBoxLanguage.Image = (System.Drawing.Image)resources.GetObject("pictureBoxLanguage.Image");
            pictureBoxLanguage.Location = new System.Drawing.Point(17, 145);
            pictureBoxLanguage.Name = "pictureBoxLanguage";
            pictureBoxLanguage.Size = new System.Drawing.Size(402, 240);
            pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxLanguage.TabIndex = 10;
            pictureBoxLanguage.TabStop = false;
            // 
            // buttonDeleteLanguage
            // 
            buttonDeleteLanguage.Location = new System.Drawing.Point(17, 413);
            buttonDeleteLanguage.Name = "buttonDeleteLanguage";
            buttonDeleteLanguage.Size = new System.Drawing.Size(128, 43);
            buttonDeleteLanguage.TabIndex = 9;
            buttonDeleteLanguage.Text = "Delete";
            buttonDeleteLanguage.UseVisualStyleBackColor = true;
            buttonDeleteLanguage.Click += buttonDeleteLanguage_Click;
            // 
            // buttonUpdateLanguage
            // 
            buttonUpdateLanguage.Location = new System.Drawing.Point(154, 411);
            buttonUpdateLanguage.Name = "buttonUpdateLanguage";
            buttonUpdateLanguage.Size = new System.Drawing.Size(128, 43);
            buttonUpdateLanguage.TabIndex = 7;
            buttonUpdateLanguage.Text = "Update";
            buttonUpdateLanguage.UseVisualStyleBackColor = true;
            buttonUpdateLanguage.Click += buttonUpdateLanguage_Click;
            // 
            // buttonInsertLanguage
            // 
            buttonInsertLanguage.Location = new System.Drawing.Point(291, 413);
            buttonInsertLanguage.Name = "buttonInsertLanguage";
            buttonInsertLanguage.Size = new System.Drawing.Size(128, 43);
            buttonInsertLanguage.TabIndex = 6;
            buttonInsertLanguage.Text = "Insert";
            buttonInsertLanguage.UseVisualStyleBackColor = true;
            buttonInsertLanguage.Click += buttonInsertLanguage_Click;
            // 
            // buttonSaveLanguage
            // 
            buttonSaveLanguage.Location = new System.Drawing.Point(154, 413);
            buttonSaveLanguage.Name = "buttonSaveLanguage";
            buttonSaveLanguage.Size = new System.Drawing.Size(128, 43);
            buttonSaveLanguage.TabIndex = 8;
            buttonSaveLanguage.Text = "Save";
            buttonSaveLanguage.UseVisualStyleBackColor = true;
            buttonSaveLanguage.Click += buttonSaveLanguage_Click;
            // 
            // textBoxCodeLanguage
            // 
            textBoxCodeLanguage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxCodeLanguage.Location = new System.Drawing.Point(140, 92);
            textBoxCodeLanguage.Multiline = true;
            textBoxCodeLanguage.Name = "textBoxCodeLanguage";
            textBoxCodeLanguage.Size = new System.Drawing.Size(279, 23);
            textBoxCodeLanguage.TabIndex = 9;
            // 
            // textBoxNameLanguage
            // 
            textBoxNameLanguage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxNameLanguage.Location = new System.Drawing.Point(79, 55);
            textBoxNameLanguage.Multiline = true;
            textBoxNameLanguage.Name = "textBoxNameLanguage";
            textBoxNameLanguage.Size = new System.Drawing.Size(340, 23);
            textBoxNameLanguage.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(17, 92);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(117, 22);
            label11.TabIndex = 0;
            label11.Text = "Код на езика:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(17, 55);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(52, 22);
            label10.TabIndex = 0;
            label10.Text = "Език:";
            // 
            // groupBoxPublisher
            // 
            groupBoxPublisher.BackColor = System.Drawing.Color.White;
            groupBoxPublisher.Controls.Add(pictureBoxPublisher);
            groupBoxPublisher.Controls.Add(buttonDeletePublisher);
            groupBoxPublisher.Controls.Add(buttonUpdatePublisher);
            groupBoxPublisher.Controls.Add(buttonInsertPublisher);
            groupBoxPublisher.Controls.Add(buttonSavePublisher);
            groupBoxPublisher.Controls.Add(textBoxNamePublisher);
            groupBoxPublisher.Controls.Add(label13);
            groupBoxPublisher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxPublisher.Location = new System.Drawing.Point(473, 147);
            groupBoxPublisher.Name = "groupBoxPublisher";
            groupBoxPublisher.Size = new System.Drawing.Size(168, 50);
            groupBoxPublisher.TabIndex = 5;
            groupBoxPublisher.TabStop = false;
            groupBoxPublisher.Text = "Издателства";
            groupBoxPublisher.Visible = false;
            // 
            // pictureBoxPublisher
            // 
            pictureBoxPublisher.Image = (System.Drawing.Image)resources.GetObject("pictureBoxPublisher.Image");
            pictureBoxPublisher.Location = new System.Drawing.Point(17, 149);
            pictureBoxPublisher.Name = "pictureBoxPublisher";
            pictureBoxPublisher.Size = new System.Drawing.Size(402, 240);
            pictureBoxPublisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxPublisher.TabIndex = 10;
            pictureBoxPublisher.TabStop = false;
            // 
            // buttonDeletePublisher
            // 
            buttonDeletePublisher.Location = new System.Drawing.Point(17, 423);
            buttonDeletePublisher.Name = "buttonDeletePublisher";
            buttonDeletePublisher.Size = new System.Drawing.Size(128, 43);
            buttonDeletePublisher.TabIndex = 9;
            buttonDeletePublisher.Text = "Delete";
            buttonDeletePublisher.UseVisualStyleBackColor = true;
            buttonDeletePublisher.Click += buttonDeletePublisher_Click;
            // 
            // buttonUpdatePublisher
            // 
            buttonUpdatePublisher.Location = new System.Drawing.Point(154, 423);
            buttonUpdatePublisher.Name = "buttonUpdatePublisher";
            buttonUpdatePublisher.Size = new System.Drawing.Size(128, 43);
            buttonUpdatePublisher.TabIndex = 7;
            buttonUpdatePublisher.Text = "Update";
            buttonUpdatePublisher.UseVisualStyleBackColor = true;
            buttonUpdatePublisher.Click += buttonUpdatePublisher_Click;
            // 
            // buttonInsertPublisher
            // 
            buttonInsertPublisher.Location = new System.Drawing.Point(291, 423);
            buttonInsertPublisher.Name = "buttonInsertPublisher";
            buttonInsertPublisher.Size = new System.Drawing.Size(128, 43);
            buttonInsertPublisher.TabIndex = 6;
            buttonInsertPublisher.Text = "Insert";
            buttonInsertPublisher.UseVisualStyleBackColor = true;
            buttonInsertPublisher.Click += buttonInsertPublisher_Click;
            // 
            // buttonSavePublisher
            // 
            buttonSavePublisher.Location = new System.Drawing.Point(154, 423);
            buttonSavePublisher.Name = "buttonSavePublisher";
            buttonSavePublisher.Size = new System.Drawing.Size(128, 43);
            buttonSavePublisher.TabIndex = 8;
            buttonSavePublisher.Text = "Save";
            buttonSavePublisher.UseVisualStyleBackColor = true;
            buttonSavePublisher.Click += buttonSavePublisher_Click;
            // 
            // textBoxNamePublisher
            // 
            textBoxNamePublisher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxNamePublisher.Location = new System.Drawing.Point(141, 73);
            textBoxNamePublisher.Multiline = true;
            textBoxNamePublisher.Name = "textBoxNamePublisher";
            textBoxNamePublisher.Size = new System.Drawing.Size(278, 23);
            textBoxNamePublisher.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(17, 73);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(118, 22);
            label13.TabIndex = 0;
            label13.Text = "Издателство:";
            // 
            // btnGoBackToMainForm
            // 
            btnGoBackToMainForm.BackColor = System.Drawing.Color.Lavender;
            btnGoBackToMainForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGoBackToMainForm.Location = new System.Drawing.Point(473, 441);
            btnGoBackToMainForm.Name = "btnGoBackToMainForm";
            btnGoBackToMainForm.Size = new System.Drawing.Size(255, 55);
            btnGoBackToMainForm.TabIndex = 11;
            btnGoBackToMainForm.Text = "Върни се към Главната форма";
            btnGoBackToMainForm.UseVisualStyleBackColor = false;
            btnGoBackToMainForm.Click += btnGoBackToMainForm_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(17, 54);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(63, 22);
            label12.TabIndex = 0;
            label12.Text = "Автор:";
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxAuthorName.Location = new System.Drawing.Point(86, 54);
            textBoxAuthorName.Multiline = true;
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new System.Drawing.Size(333, 23);
            textBoxAuthorName.TabIndex = 9;
            // 
            // buttonSaveAuthor
            // 
            buttonSaveAuthor.Location = new System.Drawing.Point(154, 423);
            buttonSaveAuthor.Name = "buttonSaveAuthor";
            buttonSaveAuthor.Size = new System.Drawing.Size(128, 43);
            buttonSaveAuthor.TabIndex = 8;
            buttonSaveAuthor.Text = "Save";
            buttonSaveAuthor.UseVisualStyleBackColor = true;
            buttonSaveAuthor.Click += buttonSaveAuthor_Click;
            // 
            // buttonInsertAuthor
            // 
            buttonInsertAuthor.Location = new System.Drawing.Point(291, 423);
            buttonInsertAuthor.Name = "buttonInsertAuthor";
            buttonInsertAuthor.Size = new System.Drawing.Size(128, 43);
            buttonInsertAuthor.TabIndex = 6;
            buttonInsertAuthor.Text = "Insert";
            buttonInsertAuthor.UseVisualStyleBackColor = true;
            buttonInsertAuthor.Click += buttonInsertAuthor_Click;
            // 
            // buttonUpdateAuthor
            // 
            buttonUpdateAuthor.Location = new System.Drawing.Point(154, 424);
            buttonUpdateAuthor.Name = "buttonUpdateAuthor";
            buttonUpdateAuthor.Size = new System.Drawing.Size(128, 43);
            buttonUpdateAuthor.TabIndex = 7;
            buttonUpdateAuthor.Text = "Update";
            buttonUpdateAuthor.UseVisualStyleBackColor = true;
            buttonUpdateAuthor.Click += buttonUpdateAuthor_Click;
            // 
            // buttonDeleteAuthor
            // 
            buttonDeleteAuthor.Location = new System.Drawing.Point(17, 423);
            buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            buttonDeleteAuthor.Size = new System.Drawing.Size(128, 43);
            buttonDeleteAuthor.TabIndex = 9;
            buttonDeleteAuthor.Text = "Delete";
            buttonDeleteAuthor.UseVisualStyleBackColor = true;
            buttonDeleteAuthor.Click += buttonDeleteAuthor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(17, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(402, 240);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(17, 93);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(127, 22);
            label14.TabIndex = 11;
            label14.Text = "Националност:";
            // 
            // textBoxAuthorNationality
            // 
            textBoxAuthorNationality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxAuthorNationality.Location = new System.Drawing.Point(150, 93);
            textBoxAuthorNationality.Multiline = true;
            textBoxAuthorNationality.Name = "textBoxAuthorNationality";
            textBoxAuthorNationality.Size = new System.Drawing.Size(269, 23);
            textBoxAuthorNationality.TabIndex = 12;
            // 
            // groupBoxAuthors
            // 
            groupBoxAuthors.BackColor = System.Drawing.Color.White;
            groupBoxAuthors.Controls.Add(textBoxAuthorNationality);
            groupBoxAuthors.Controls.Add(label14);
            groupBoxAuthors.Controls.Add(pictureBox1);
            groupBoxAuthors.Controls.Add(buttonDeleteAuthor);
            groupBoxAuthors.Controls.Add(buttonUpdateAuthor);
            groupBoxAuthors.Controls.Add(buttonInsertAuthor);
            groupBoxAuthors.Controls.Add(buttonSaveAuthor);
            groupBoxAuthors.Controls.Add(textBoxAuthorName);
            groupBoxAuthors.Controls.Add(label12);
            groupBoxAuthors.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxAuthors.Location = new System.Drawing.Point(473, 12);
            groupBoxAuthors.Name = "groupBoxAuthors";
            groupBoxAuthors.Size = new System.Drawing.Size(108, 30);
            groupBoxAuthors.TabIndex = 10;
            groupBoxAuthors.TabStop = false;
            groupBoxAuthors.Text = "Автори";
            groupBoxAuthors.Visible = false;
            // 
            // buttonInsertData
            // 
            buttonInsertData.BackColor = System.Drawing.Color.Lavender;
            buttonInsertData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonInsertData.Location = new System.Drawing.Point(749, 441);
            buttonInsertData.Name = "buttonInsertData";
            buttonInsertData.Size = new System.Drawing.Size(255, 53);
            buttonInsertData.TabIndex = 18;
            buttonInsertData.Text = "Вмъкни данни";
            buttonInsertData.UseVisualStyleBackColor = false;
            buttonInsertData.Click += buttonInsertData_Click;
            // 
            // ImproveOurCatalog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(1016, 511);
            Controls.Add(buttonInsertData);
            Controls.Add(groupBoxGenre);
            Controls.Add(groupBoxBook);
            Controls.Add(btnGoBackToMainForm);
            Controls.Add(groupBoxPublisher);
            Controls.Add(groupBoxLanguage);
            Controls.Add(groupBoxNationality);
            Controls.Add(comboBoxFilter);
            Controls.Add(dataGridViewTables);
            Controls.Add(groupBoxAuthors);
            Controls.Add(dateTimePickerPublicationYear);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ImproveOurCatalog";
            Text = "ImproveOurCatalog";
            Load += ImproveOurCatalog_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).EndInit();
            groupBoxBook.ResumeLayout(false);
            groupBoxBook.PerformLayout();
            groupBoxNationality.ResumeLayout(false);
            groupBoxNationality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNationality).EndInit();
            groupBoxGenre.ResumeLayout(false);
            groupBoxGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenre).EndInit();
            groupBoxLanguage.ResumeLayout(false);
            groupBoxLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLanguage).EndInit();
            groupBoxPublisher.ResumeLayout(false);
            groupBoxPublisher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublisher).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxAuthors.ResumeLayout(false);
            groupBoxAuthors.PerformLayout();
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
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.Button buttonInsertBook;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.GroupBox groupBoxGenre;
        private System.Windows.Forms.Button buttonDeleteGenre;
        private System.Windows.Forms.Button buttonUpdateGenre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonInsertGenre;
        private System.Windows.Forms.Button buttonSaveGenre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxGenreName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBoxGenre;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
        private System.Windows.Forms.Button buttonDeleteLanguage;
        private System.Windows.Forms.Button buttonUpdateLanguage;
        private System.Windows.Forms.Button buttonInsertLanguage;
        private System.Windows.Forms.Button buttonSaveLanguage;
        private System.Windows.Forms.TextBox textBoxNameLanguage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCodeLanguage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxPublisher;
        private System.Windows.Forms.PictureBox pictureBoxPublisher;
        private System.Windows.Forms.Button buttonDeletePublisher;
        private System.Windows.Forms.Button buttonUpdatePublisher;
        private System.Windows.Forms.Button buttonInsertPublisher;
        private System.Windows.Forms.Button buttonSavePublisher;
        private System.Windows.Forms.TextBox textBoxNamePublisher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxNationality;
        private System.Windows.Forms.PictureBox pictureBoxNationality;
        private System.Windows.Forms.Button buttonDeleteNationality;
        private System.Windows.Forms.Button buttonUpdateNationality;
        private System.Windows.Forms.Button buttonInsertNationality;
        private System.Windows.Forms.Button buttonSaveNationality;
        private System.Windows.Forms.TextBox textBoxNameNationality;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGoBackToMainForm;
        private System.Windows.Forms.TextBox textBoxNationalityNameBook;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Button buttonSaveAuthor;
        private System.Windows.Forms.Button buttonInsertAuthor;
        private System.Windows.Forms.Button buttonUpdateAuthor;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxAuthorNationality;
        private System.Windows.Forms.GroupBox groupBoxAuthors;
        private System.Windows.Forms.Button buttonInsertData;
    }
}