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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeChangeToTheCatalog = new System.Windows.Forms.Button();
            this.btnCatalogNavigaton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(565, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 66);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 286);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMakeChangeToTheCatalog
            // 
            this.btnMakeChangeToTheCatalog.BackColor = System.Drawing.Color.Lavender;
            this.btnMakeChangeToTheCatalog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMakeChangeToTheCatalog.Location = new System.Drawing.Point(288, 312);
            this.btnMakeChangeToTheCatalog.Name = "btnMakeChangeToTheCatalog";
            this.btnMakeChangeToTheCatalog.Size = new System.Drawing.Size(260, 66);
            this.btnMakeChangeToTheCatalog.TabIndex = 3;
            this.btnMakeChangeToTheCatalog.Text = "Обогати каталога";
            this.btnMakeChangeToTheCatalog.UseVisualStyleBackColor = false;
            this.btnMakeChangeToTheCatalog.Click += new System.EventHandler(this.btnMakeChangeToTheCatalog_Click_1);
            // 
            // btnCatalogNavigaton
            // 
            this.btnCatalogNavigaton.BackColor = System.Drawing.Color.Lavender;
            this.btnCatalogNavigaton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCatalogNavigaton.Location = new System.Drawing.Point(12, 312);
            this.btnCatalogNavigaton.Name = "btnCatalogNavigaton";
            this.btnCatalogNavigaton.Size = new System.Drawing.Size(260, 66);
            this.btnCatalogNavigaton.TabIndex = 4;
            this.btnCatalogNavigaton.Text = "Разгледай каталога";
            this.btnCatalogNavigaton.UseVisualStyleBackColor = false;
            this.btnCatalogNavigaton.Click += new System.EventHandler(this.btnCatalogNavigaton_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(836, 393);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeChangeToTheCatalog);
            this.Controls.Add(this.btnCatalogNavigaton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeChangeToTheCatalog;
        private System.Windows.Forms.Button btnCatalogNavigaton;
    }
}
