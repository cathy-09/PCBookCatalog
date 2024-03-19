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
            this.comboBoxChooseOption = new System.Windows.Forms.ComboBox();
            this.btnGoBackToMainForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChooseOption
            // 
            this.comboBoxChooseOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseOption.FormattingEnabled = true;
            this.comboBoxChooseOption.Items.AddRange(new object[] {
            "Списък на книги",
            "Сортирани по заглавие книги"});
            this.comboBoxChooseOption.Location = new System.Drawing.Point(975, 5);
            this.comboBoxChooseOption.Name = "comboBoxChooseOption";
            this.comboBoxChooseOption.Size = new System.Drawing.Size(158, 23);
            this.comboBoxChooseOption.TabIndex = 7;
            this.comboBoxChooseOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseOption_SelectedIndexChanged_1);
            // 
            // btnGoBackToMainForm
            // 
            this.btnGoBackToMainForm.BackColor = System.Drawing.Color.Lavender;
            this.btnGoBackToMainForm.Location = new System.Drawing.Point(12, 417);
            this.btnGoBackToMainForm.Name = "btnGoBackToMainForm";
            this.btnGoBackToMainForm.Size = new System.Drawing.Size(1121, 38);
            this.btnGoBackToMainForm.TabIndex = 6;
            this.btnGoBackToMainForm.Text = "Върни се към Главната форма";
            this.btnGoBackToMainForm.UseVisualStyleBackColor = false;
            this.btnGoBackToMainForm.Click += new System.EventHandler(this.btnGoBackToMainForm_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 377);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(367, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Разгледай всички книги, включени в каталога ни!";
            // 
            // BookCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1143, 461);
            this.Controls.Add(this.comboBoxChooseOption);
            this.Controls.Add(this.btnGoBackToMainForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookCatalogForm";
            this.Text = "BookCatalogForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseOption;
        private System.Windows.Forms.Button btnGoBackToMainForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}