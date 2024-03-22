using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Models;

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

        private void btnCatalogNavigaton_Click_1(object sender, EventArgs e)
        {
            BookCatalogForm bookForm = new BookCatalogForm(this);
            bookForm.Show();
        }

        private void btnMakeChangeToTheCatalog_Click_1(object sender, EventArgs e)
        {
            ImproveOurCatalog catalog = new ImproveOurCatalog(this);
            catalog.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdditional_Click(object sender, EventArgs e)
        {
            AdditionalFunctionalities additionalFunctionalities = new AdditionalFunctionalities(this);
            additionalFunctionalities.Show();
        }
    }
}
