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
using Data.Models;

namespace Display1
{
    public partial class BookCatalogForm : Form
    {
        private BookBusiness bookBusiness = new BookBusiness();
        private MainForm mainForm;

        public BookCatalogForm(MainForm mainForm)
        {
            InitializeComponent();
            InsertInitialData();
            this.mainForm = mainForm;
            mainForm.Visible = false;
        }

        private void BookCatalogForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxDataOnce();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = bookBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void comboBoxChooseOption_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxChooseOption.SelectedIndex == 0)
            {
                UpdateGrid();
            }
            else if (comboBoxChooseOption.SelectedIndex == 1)
            {
                LoadBooksSortedByTitle();
                //UpdateGrid();
            }
        }
        private void LoadBooksSortedByTitle()
        {
            BookBusiness bookBusiness = new BookBusiness();
            List<BookPlaceholder> sortedBooks = bookBusiness.GetBooksSortedByTitle();
            dataGridView1.DataSource = sortedBooks;
            DataGridViewColumn sortedColumn = dataGridView1.Columns["Name"];
            ListSortDirection sortDirection = ListSortDirection.Ascending;
            dataGridView1.Sort(sortedColumn, sortDirection);
        }
        private bool comboBoxDataLoaded = false;

        private void LoadComboBoxDataOnce()
        {
            if (!comboBoxDataLoaded)
            {
                comboBoxChooseOption.Items.Add("Списък на книги");
                comboBoxChooseOption.Items.Add("Сортиране по заглавие");
                comboBoxChooseOption.SelectedIndex = 0; 

                comboBoxDataLoaded = true;
            }
        }
        private void InsertInitialData()
        {
            bookBusiness.InsertInitialData();
        }

        private void btnGoBackToMainForm_Click_1(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            Close();
        }

        private void BookCatalogForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
