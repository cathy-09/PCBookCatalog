namespace Display1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCatalogForm));
            comboBoxChooseOption = new System.Windows.Forms.ComboBox();
            btnGoBackToMainForm = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxChooseOption
            // 
            comboBoxChooseOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxChooseOption.FormattingEnabled = true;
            comboBoxChooseOption.Items.AddRange(new object[] { "Списък на книги", "Сортирани по заглавие книги" });
            comboBoxChooseOption.Location = new System.Drawing.Point(975, 5);
            comboBoxChooseOption.Name = "comboBoxChooseOption";
            comboBoxChooseOption.Size = new System.Drawing.Size(158, 23);
            comboBoxChooseOption.TabIndex = 7;
            comboBoxChooseOption.SelectedIndexChanged += comboBoxChooseOption_SelectedIndexChanged_1;
            // 
            // btnGoBackToMainForm
            // 
            btnGoBackToMainForm.BackColor = System.Drawing.Color.Lavender;
            btnGoBackToMainForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGoBackToMainForm.Location = new System.Drawing.Point(12, 417);
            btnGoBackToMainForm.Name = "btnGoBackToMainForm";
            btnGoBackToMainForm.Size = new System.Drawing.Size(1121, 38);
            btnGoBackToMainForm.TabIndex = 6;
            btnGoBackToMainForm.Text = "Върни се към Главната форма";
            btnGoBackToMainForm.UseVisualStyleBackColor = false;
            btnGoBackToMainForm.Click += btnGoBackToMainForm_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1121, 377);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(367, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(400, 22);
            label1.TabIndex = 4;
            label1.Text = "Разгледай всички книги, включени в каталога ни!";
            // 
            // BookCatalogForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(1143, 461);
            Controls.Add(comboBoxChooseOption);
            Controls.Add(btnGoBackToMainForm);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "BookCatalogForm";
            Text = "BookCatalogForm";
            Load += BookCatalogForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseOption;
        private System.Windows.Forms.Button btnGoBackToMainForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}