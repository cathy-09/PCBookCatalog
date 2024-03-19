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

namespace Display1
{
    public partial class ImproveOurCatalog : Form
    {
        private BookBusiness bookBusiness = new BookBusiness();
        private BussinessAuthors bussinessAuthors = new BussinessAuthors();
        private GenresBusiness genresBusiness = new GenresBusiness();
        private BusinessNationalities businessNationalities = new BusinessNationalities();
        private LanguagesBusiness languagesBusiness = new LanguagesBusiness();
        private PublishersBusiness publishersBusiness = new PublishersBusiness();
        private MainForm mainForm;

        public ImproveOurCatalog(MainForm mainForm)
        {
            InitializeComponent();
            groupBoxBook.Visible = false;

            groupBoxGenre.Visible = false;
            groupBoxGenre.Size = groupBoxBook.Size;
            groupBoxGenre.Location = groupBoxBook.Location;

            groupBoxNationality.Visible = false;
            groupBoxNationality.Size = groupBoxBook.Size;
            groupBoxNationality.Location = groupBoxBook.Location;

            groupBoxAuthors.Visible = false;
            groupBoxAuthors.Size = groupBoxBook.Size;
            groupBoxAuthors.Location = groupBoxBook.Location;

            groupBoxLanguage.Visible = false;
            groupBoxLanguage.Size = groupBoxBook.Size;
            groupBoxLanguage.Location = groupBoxBook.Location;

            groupBoxPublisher.Visible = false;
            groupBoxPublisher.Size = groupBoxBook.Size;
            groupBoxPublisher.Location = groupBoxBook.Location;

            this.mainForm = mainForm;
            mainForm.Visible = false;
        }

        private void UpdateGrid(string grid)
        {
            switch (grid)
            {
                case "Genres":
                    groupBoxGenre.Visible = true;
                    groupBoxBook.Visible = false;
                    groupBoxPublisher.Visible = false;
                    groupBoxLanguage.Visible = false;
                    groupBoxNationality.Visible = false;
                    groupBoxAuthors.Visible = false;
                    dataGridViewTables.DataSource = genresBusiness.GetAll();
                    dataGridViewTables.ReadOnly = true;
                    dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case "Nationalities":
                    groupBoxBook.Visible = false;
                    groupBoxGenre.Visible = false;
                    groupBoxPublisher.Visible = false;
                    groupBoxLanguage.Visible = false;
                    groupBoxNationality.Visible = true;
                    groupBoxAuthors.Visible = false;
                    dataGridViewTables.DataSource = businessNationalities.GetAllNationalities();
                    dataGridViewTables.ReadOnly = true;
                    dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case "Authors":
                    groupBoxBook.Visible = false;
                    groupBoxGenre.Visible = false;
                    groupBoxPublisher.Visible = false;
                    groupBoxLanguage.Visible = false;
                    groupBoxNationality.Visible = false;
                    groupBoxAuthors.Visible = true;
                    dataGridViewTables.DataSource = bussinessAuthors.GetAll();
                    dataGridViewTables.ReadOnly = true;
                    dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case "Books":
                    groupBoxBook.Visible = true;
                    groupBoxGenre.Visible = false;
                    groupBoxPublisher.Visible = false;
                    groupBoxLanguage.Visible = false;
                    groupBoxNationality.Visible = false;
                    groupBoxAuthors.Visible = false;
                    dataGridViewTables.DataSource = bookBusiness.GetAll();
                    dataGridViewTables.ReadOnly = true;
                    dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case "Languages":
                    groupBoxBook.Visible = false;
                    groupBoxGenre.Visible = false;
                    groupBoxPublisher.Visible = false;
                    groupBoxLanguage.Visible = true;
                    groupBoxNationality.Visible = false;
                    groupBoxAuthors.Visible = false;
                    dataGridViewTables.DataSource = languagesBusiness.GetAll();
                    dataGridViewTables.ReadOnly = true;
                    dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case "Publishers":
                    groupBoxBook.Visible = false;
                    groupBoxGenre.Visible = false;
                    groupBoxPublisher.Visible = true;
                    groupBoxLanguage.Visible = false;
                    groupBoxNationality.Visible = false;
                    groupBoxAuthors.Visible = false;
                    dataGridViewTables.DataSource = publishersBusiness.GetAllPublishers();
                    dataGridViewTables.ReadOnly = true;
                    dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
            }
        }

        private void comboBoxFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBoxFilter.Text)
            {
                case "Жанрове":
                    UpdateGrid("Genres");
                    break;
                case "Националности":
                    UpdateGrid("Nationalities");
                    break;
                case "Автори":
                    UpdateGrid("Authors");
                    break;
                case "Книги":
                    UpdateGrid("Books");
                    break;
                case "Издателства":
                    UpdateGrid("Publishers");
                    break;
                case "Езици":
                    UpdateGrid("Languages");
                    break;
            }
        }

        private void dataGridViewTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImproveOurCatalog_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxBook_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonUpdateGenre_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilter_Click(object sender, EventArgs e)
        {

        }

        private void ImproveOurCatalog_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGoBackToMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            Close();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

        }
    }
}
