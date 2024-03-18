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
        private MainForm mainForm;

        public BookCatalogForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.Visible = false;
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

        private void comboBoxChooseOption_SelectedIndexChanged_1(object sender, EventArgs e)
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
        private void InsertInitialData()
        {
            bookBusiness.InsertInitialData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoBackToMainForm_Click_1(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
