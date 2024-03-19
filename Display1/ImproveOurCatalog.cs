using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        private int editIdBook = 0;
        private int editIdAuthor = 0;
        private int editIdNationality = 0;
        private int editIdLanguage = 0;
        private int editIdGenre = 0;
        private int editIdPublisher = 0;
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

        private void ImproveOurCatalog_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGoBackToMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            Close();
        }
        private void UpdateGridBook()
        {
            dataGridViewTables.DataSource = bookBusiness.GetAll();
            dataGridViewTables.ReadOnly = true;
            dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                bookBusiness.Delete(id);
                UpdateGridBook();
                ResetSelect();
            }
        }
        private void DisableSelect()
        {
            dataGridViewTables.Enabled = false;
        }

        private void ResetSelect()
        {
            dataGridViewTables.ClearSelection();
            dataGridViewTables.Enabled = true;
        }
        private void ToggleSaveUpdateAuthor()
        {
            if (buttonUpdateAuthor.Visible)
            {
                buttonSaveAuthor.Visible = true;
                buttonUpdateAuthor.Visible = false;
            }
            else
            {
                buttonSaveAuthor.Visible = false;
                buttonUpdateAuthor.Visible = true;
            }
        }
        private void ToggleSaveUpdateBook()
        {
            if (buttonUpdateBook.Visible)
            {
                buttonSaveBook.Visible = true;
                buttonUpdateBook.Visible = false;
            }
            else
            {
                buttonSaveBook.Visible = false;
                buttonUpdateBook.Visible = true;
            }
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                UpdateTextBoxes(id);
                UpdateGridBook();
                ResetSelect();
            }
        }

        private void UpdateTextBoxes(int id)
        {
            BookPlaceholder kniga = bookBusiness.GetBookPlaceholder(id);
            textBoxTitle.Text = kniga.Name;
            textBoxAuthor.Text = kniga.Author;
            textBoxPublishers.Text = kniga.Publisher;
            textBoxGenre.Text = kniga.Genre;
            textBoxPrice.Text = kniga.Price.ToString();
            textBoxRating.Text = kniga.Rating.ToString();
            textBoxISBN.Text = kniga.ISBN;
            textBoxPublicationYear.Text = kniga.PublicationYear.ToString();
            textBoxLanguage.Text = kniga.Language;
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            BookPlaceholder editedBook = GetEditedBook();
            Book finalBook = new Book()
            {
                Name = editedBook.Name,
                Genre = new Genre { GenreName = editedBook.Genre },
                Author = new Author { Name = editedBook.Author },
                Publisher = new Publisher { PublisherName = editedBook.Publisher },
                Rating = editedBook.Rating,
                Pages = editedBook.Pages,
                Price = editedBook.Price,
                ISBN = editedBook.ISBN,
                PublicationYear = editedBook.PublicationYear,
                Language = new Language { LanguageName = editedBook.Language }
            };
            bookBusiness.Update(finalBook);
            UpdateGridBook();
            ResetSelect();
            ToggleSaveUpdateBook();
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxPublishers.Text = "";
            textBoxGenre.Text = "";
            textBoxPrice.Text = "";
            textBoxRating.Text = "";
            textBoxISBN.Text = "";
            textBoxPublicationYear.Text = "";
            textBoxLanguage.Text = "";
        }
        private BookPlaceholder GetEditedBook()
        {
            BookPlaceholder book = new BookPlaceholder();
            book.Id = editIdBook;

            var name = textBoxTitle.Text;
            var author = textBoxAuthor.Text;
            var publisher = textBoxPublishers.Text;
            var genre = textBoxGenre.Text;
            decimal price = 0;
            decimal.TryParse(textBoxPrice.Text, out price);
            int rating = 0;
            int.TryParse(textBoxRating.Text, out rating);
            var isbn = textBoxISBN.Text;
            int yearOfPublishing = 0;
            int.TryParse(textBoxPublicationYear.Text, out yearOfPublishing);
            var language = textBoxLanguage.Text;
            book.Name = name;
            book.Author = author;
            book.Publisher = publisher;
            book.Genre = genre;
            book.Price = price;
            book.Rating = rating;
            book.ISBN = isbn;
            book.PublicationYear = yearOfPublishing;
            book.Language = language;
            return book;
        }

        private void buttonInsertBook_Click(object sender, EventArgs e)
        {
            var name = textBoxTitle.Text;
            var author = textBoxAuthor.Text;
            var publisher = textBoxPublishers.Text;
            var genre = textBoxGenre.Text;
            var nationality = textBoxNationalityNameBook.Text;
            int pages = 0;
            int.TryParse(textBoxPages.Text, out pages);
            decimal price = 0;
            decimal.TryParse(textBoxPrice.Text, out price);
            int rating = 0;
            int.TryParse(textBoxRating.Text, out rating);
            var isbn = textBoxISBN.Text;
            int yearOfPublishing = 0;
            int.TryParse(textBoxPublicationYear.Text, out yearOfPublishing);
            var language = textBoxLanguage.Text;
            Book book = new Book();
            book.Name = name;
            book.Author = new Author { Name = author, Nationality = new Nationality { Name = nationality } };
            book.Publisher = new Publisher { PublisherName = publisher };
            book.Genre = new Genre { GenreName = genre };
            book.Price = price;
            book.Rating = rating;
            book.Pages = pages;
            book.ISBN = isbn;
            book.PublicationYear = yearOfPublishing;
            book.Language = new Language { LanguageName = language };
            bookBusiness.Add(book);
            UpdateGridBook();
            ClearTextBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
