namespace Display
{
    partial class BookCatalogForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnGoBackToMainForm = new Button();
            comboBoxChooseOption = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(400, 22);
            label1.TabIndex = 0;
            label1.Text = "Разгледай всички книги, включени в каталога ни!";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1121, 377);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnGoBackToMainForm
            // 
            btnGoBackToMainForm.BackColor = Color.Lavender;
            btnGoBackToMainForm.Location = new Point(12, 422);
            btnGoBackToMainForm.Name = "btnGoBackToMainForm";
            btnGoBackToMainForm.Size = new Size(1121, 38);
            btnGoBackToMainForm.TabIndex = 2;
            btnGoBackToMainForm.Text = "Върни се към Главната форма";
            btnGoBackToMainForm.UseVisualStyleBackColor = false;
            btnGoBackToMainForm.Click += btnGoBackToMainForm_Click;
            // 
            // comboBoxChooseOption
            // 
            comboBoxChooseOption.FormattingEnabled = true;
            comboBoxChooseOption.Items.AddRange(new object[] { "Списък на книги", "Сортирани по заглавие книги" });
            comboBoxChooseOption.Location = new Point(975, 10);
            comboBoxChooseOption.Name = "comboBoxChooseOption";
            comboBoxChooseOption.Size = new Size(158, 23);
            comboBoxChooseOption.TabIndex = 3;
            comboBoxChooseOption.SelectedIndexChanged += comboBoxChooseOption_SelectedIndexChanged;
            // 
            // BookCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1145, 472);
            Controls.Add(comboBoxChooseOption);
            Controls.Add(btnGoBackToMainForm);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "BookCatalogForm";
            Text = "BookCatalogForm";
            Load += BookCatalogForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnGoBackToMainForm;
        private ComboBox comboBoxChooseOption;
    }
}