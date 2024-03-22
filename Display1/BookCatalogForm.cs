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
            if (comboBoxChooseOption.Text.Equals("Списък на книги"))
            {
                UpdateGrid();
            }
            else
            {
                BubbleSortBookTitle();
                UpdateGrid();
            }
        }
        private void BubbleSortBookTitle()
        {
            if (dataGridView1.DataSource is List<Book> books && books.Count > 0)
            {
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    for (int i = 0; i < books.Count - 1; i++)
                    {
                        if (books[i].Name.CompareTo(books[i + 1].Name) > 0)
                        {
                            Book temp = books[i];
                            books[i] = books[i + 1];
                            books[i + 1] = temp;

                            flag = true;
                        }
                    }
                }
                dataGridView1.DataSource = books;
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
