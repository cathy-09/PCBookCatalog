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
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonGetCheapestBook = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Lavender;
            button1.Location = new System.Drawing.Point(12, 406);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(776, 35);
            button1.TabIndex = 0;
            button1.Text = "Върни се към главната форма";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Controls.Add(buttonGetCheapestBook);
            groupBox1.Location = new System.Drawing.Point(10, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(320, 387);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Допълнителни функционалности";
            // 
            // buttonGetCheapestBook
            // 
            buttonGetCheapestBook.Location = new System.Drawing.Point(6, 22);
            buttonGetCheapestBook.Name = "buttonGetCheapestBook";
            buttonGetCheapestBook.Size = new System.Drawing.Size(296, 46);
            buttonGetCheapestBook.TabIndex = 0;
            buttonGetCheapestBook.Text = "Намери най-евтината книга";
            buttonGetCheapestBook.UseVisualStyleBackColor = true;
            buttonGetCheapestBook.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(336, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(452, 387);
            dataGridView1.TabIndex = 2;
            // 
            // AdditionalFunctionalities
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "AdditionalFunctionalities";
            Text = "AdditionalFunctionalities";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGetCheapestBook;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}