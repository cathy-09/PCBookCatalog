using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeChangeToTheCatalog_Click(object sender, EventArgs e)
        {
            ImproveOurCatalog improveOurCatalog = new ImproveOurCatalog();
            improveOurCatalog.Show();
        }

        private void btnCatalogNavigaton_Click(object sender, EventArgs e)
        {
            BookCatalogForm bookCatalogForm = new BookCatalogForm();
            bookCatalogForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCatalogNavigaton_Click_1(object sender, EventArgs e)
        {
            BookCatalogForm bookCatalogForm = new BookCatalogForm();
            bookCatalogForm.Show();
        }
    }
}
