namespace Display1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnExit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnMakeChangeToTheCatalog = new System.Windows.Forms.Button();
            btnCatalogNavigaton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Lavender;
            btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(565, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(260, 66);
            btnExit.TabIndex = 6;
            btnExit.Text = "Изход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.WhiteSmoke;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(812, 286);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // btnMakeChangeToTheCatalog
            // 
            btnMakeChangeToTheCatalog.BackColor = System.Drawing.Color.Lavender;
            btnMakeChangeToTheCatalog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMakeChangeToTheCatalog.Location = new System.Drawing.Point(288, 312);
            btnMakeChangeToTheCatalog.Name = "btnMakeChangeToTheCatalog";
            btnMakeChangeToTheCatalog.Size = new System.Drawing.Size(260, 66);
            btnMakeChangeToTheCatalog.TabIndex = 3;
            btnMakeChangeToTheCatalog.Text = "Обогати каталога";
            btnMakeChangeToTheCatalog.UseVisualStyleBackColor = false;
            btnMakeChangeToTheCatalog.Click += btnMakeChangeToTheCatalog_Click_1;
            // 
            // btnCatalogNavigaton
            // 
            btnCatalogNavigaton.BackColor = System.Drawing.Color.Lavender;
            btnCatalogNavigaton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCatalogNavigaton.Location = new System.Drawing.Point(12, 312);
            btnCatalogNavigaton.Name = "btnCatalogNavigaton";
            btnCatalogNavigaton.Size = new System.Drawing.Size(260, 66);
            btnCatalogNavigaton.TabIndex = 4;
            btnCatalogNavigaton.Text = "Разгледай каталога";
            btnCatalogNavigaton.UseVisualStyleBackColor = false;
            btnCatalogNavigaton.Click += btnCatalogNavigaton_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MistyRose;
            ClientSize = new System.Drawing.Size(836, 393);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnMakeChangeToTheCatalog);
            Controls.Add(btnCatalogNavigaton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeChangeToTheCatalog;
        private System.Windows.Forms.Button btnCatalogNavigaton;
    }
}
