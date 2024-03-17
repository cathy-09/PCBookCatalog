using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Display1
{
    public partial class BookCatalogForm : Form
    {
        private BookBusiness bookBusiness = new BookBusiness();
        public BookCatalogForm()
        {
            InitializeComponent();
        }

        private void BookCatalogForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            //InsertInitialData();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = bookBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnGoBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void InsertInitialData()
        {
            bookBusiness.InsertInitialData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxChooseOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseOption.Text.Equals("Списък на книги"))
            {
                UpdateGrid();
            }
            else
            {
                //bookBusiness.CustomSort();
                UpdateGrid();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
