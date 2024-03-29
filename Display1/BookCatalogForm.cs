﻿using System;
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
        private void UpdateGrid(List<BookPlaceholder> dataSource)
        {
            dataGridView1.DataSource = dataSource;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void comboBoxChooseOption_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxChooseOption.SelectedIndex == 0)
            {
                UpdateGrid(bookBusiness.GetAll());
            }
            else if (comboBoxChooseOption.SelectedIndex == 1)
            {
                UpdateGrid(bookBusiness.GetBooksSortedByTitle());
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
            UpdateGrid(bookBusiness.GetAll());
        }
    }
}
