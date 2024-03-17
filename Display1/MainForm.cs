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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeChangeToTheCatalog_Click(object sender, EventArgs e)
        {
            ImproveOurCatalog catalog = new ImproveOurCatalog();
            catalog.Show();
        }

        private void btnCatalogNavigaton_Click(object sender, EventArgs e)
        {
            BookCatalogForm bookForm = new BookCatalogForm();
            bookForm.Show();
        }
    }
}
