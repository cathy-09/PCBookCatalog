namespace Display
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
            btnCatalogNavigaton = new Button();
            btnMakeChangeToTheCatalog = new Button();
            label1 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCatalogNavigaton
            // 
            btnCatalogNavigaton.BackColor = Color.Lavender;
            btnCatalogNavigaton.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatalogNavigaton.Location = new Point(13, 312);
            btnCatalogNavigaton.Name = "btnCatalogNavigaton";
            btnCatalogNavigaton.Size = new Size(260, 66);
            btnCatalogNavigaton.TabIndex = 0;
            btnCatalogNavigaton.Text = "Разгледай каталога";
            btnCatalogNavigaton.UseVisualStyleBackColor = false;
            btnCatalogNavigaton.Click += btnCatalogNavigaton_Click;
            // 
            // btnMakeChangeToTheCatalog
            // 
            btnMakeChangeToTheCatalog.BackColor = Color.Lavender;
            btnMakeChangeToTheCatalog.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMakeChangeToTheCatalog.Location = new Point(289, 312);
            btnMakeChangeToTheCatalog.Name = "btnMakeChangeToTheCatalog";
            btnMakeChangeToTheCatalog.Size = new Size(260, 66);
            btnMakeChangeToTheCatalog.TabIndex = 0;
            btnMakeChangeToTheCatalog.Text = "Обогати каталога";
            btnMakeChangeToTheCatalog.UseVisualStyleBackColor = false;
            btnMakeChangeToTheCatalog.Click += btnMakeChangeToTheCatalog_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(812, 286);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Lavender;
            btnExit.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(566, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(260, 66);
            btnExit.TabIndex = 2;
            btnExit.Text = "Изход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(837, 389);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnMakeChangeToTheCatalog);
            Controls.Add(btnCatalogNavigaton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог за книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCatalogNavigaton;
        private Button btnMakeChangeToTheCatalog;
        private Label label1;
        private Button btnExit;
    }
}