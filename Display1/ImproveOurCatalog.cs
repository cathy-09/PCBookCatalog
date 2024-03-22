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
using static System.Windows.Forms.LinkLabel;

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
        private BookAuthorsBusiness booksAuthorsBusiness = new BookAuthorsBusiness();
        private int editIdBook = 0;
        private int editIdAuthor = 0;
        private int editIdNationality = 0;
        private int editIdLanguage = 0;
        private int editIdGenre = 0;
        private int editIdPublisher = 0;
        private MainForm mainForm;
        public ImproveOurCatalog improveOurCatalog;

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

        private void buttonDeleteNationality_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                businessNationalities.DeleteNationality(id);
                UpdateGridNationality();
                ResetSelect();
            }
        }

        private void buttonUpdateNationality_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editIdNationality = id;
                UpdateTextboxesNationality(id);
                ToggleSaveUpdateNationality();
                DisableSelect();
            }
        }

        private void buttonInsertNationality_Click(object sender, EventArgs e)
        {
            var name = textBoxNameNationality.Text;

            Nationality nationality = new Nationality();
            nationality.Name = name;

            businessNationalities.AddNationality(nationality);
            UpdateGridNationality();
            ClearTextBoxes();
        }
        private void ClearTextBoxesNationality()
        {
            textBoxNameNationality.Text = "";
        }
        private void UpdateGridNationality()
        {
            dataGridViewTables.DataSource = businessNationalities.GetAllNationalities();
            dataGridViewTables.ReadOnly = true;
            dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateTextboxesNationality(int id)
        {
            Nationality update = businessNationalities.GetNationaly(id);
            textBoxNameNationality.Text = update.Name;
        }
        private void ToggleSaveUpdateNationality()
        {
            if (buttonUpdateNationality.Visible)
            {
                buttonSaveNationality.Visible = true;
                buttonUpdateNationality.Visible = false;
            }
            else
            {
                buttonSaveNationality.Visible = false;
                buttonUpdateNationality.Visible = true;
            }
        }

        private Nationality GetEditedNationality()
        {
            Nationality nationality = new Nationality();
            nationality.NationalityId = editIdNationality;

            var name = textBoxNameNationality.Text;
            nationality.Name = name;

            return nationality;
        }

        private void buttonSaveNationality_Click(object sender, EventArgs e)
        {
            Nationality editedNationality = GetEditedNationality();
            businessNationalities.UpdateNationality(editedNationality);
            UpdateGridNationality();
            ResetSelect();
            ToggleSaveUpdateNationality();
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                bussinessAuthors.Delete(id);
                UpdateGridAuthor();
                ResetSelect();
            }
        }

        private void buttonUpdateAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editIdAuthor = id;
                UpdateTextboxesAuthor(id);
                ToggleSaveUpdateAuthor();
                DisableSelect();
            }
        }

        private void buttonInsertAuthor_Click(object sender, EventArgs e)
        {
            var name = textBoxAuthorName.Text;
            int authorNationality = 0;
            int.TryParse(textBoxAuthorNationality.Text, out authorNationality);

            Author author = new Author();
            author.Name = name;
            author.NationalityId = authorNationality;

            bussinessAuthors.Add(author);
            UpdateGridAuthor();
            ClearTextBoxesAuthor();
        }

        private void buttonSaveAuthor_Click(object sender, EventArgs e)
        {
            Author editedAuthor = GetEditedAuthor();
            bussinessAuthors.Update(editedAuthor);
            UpdateGridAuthor();
            ResetSelect();
            ToggleSaveUpdateAuthor();
        }
        private void ClearTextBoxesAuthor()
        {
            textBoxAuthorName.Text = "";
            textBoxAuthorNationality.Text = "";
        }
        private void UpdateGridAuthor()
        {
            dataGridViewTables.DataSource = bussinessAuthors.GetAll();
            dataGridViewTables.ReadOnly = true;
            dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTables.Columns.Remove("Nationality");
        }
        private void UpdateTextboxesAuthor(int id)
        {
            Author update = bussinessAuthors.Get(id);
            textBoxAuthorName.Text = update.Name;
            textBoxAuthorNationality.Text = update.NationalityId.ToString();
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

        private Author GetEditedAuthor()
        {
            Author author = new Author();
            author.AuthorId = editIdAuthor;

            var name = textBoxAuthorName.Text;
            int authorNationality = 0;
            int.TryParse(textBoxAuthorNationality.Text, out authorNationality);
            author.Name = name;
            author.NationalityId = authorNationality;

            return author;
        }

        private void buttonDeleteLanguage_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                languagesBusiness.Delete(id);
                UpdateGridLanguage();
                ResetSelect();
            }
        }

        private void buttonUpdateLanguage_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editIdLanguage = id;
                UpdateTextboxesLanguage(id);
                ToggleSaveUpdateLanguage();
                DisableSelect();
            }
        }

        private void buttonSaveLanguage_Click(object sender, EventArgs e)
        {
            Language editedLanguage = GetEditedLanguage();
            languagesBusiness.Update(editedLanguage);
            UpdateGridLanguage();
            ResetSelect();
            ToggleSaveUpdateLanguage();
        }

        private void buttonInsertLanguage_Click(object sender, EventArgs e)
        {
            var name = textBoxNameLanguage.Text;
            int code = 0;
            int.TryParse(textBoxCodeLanguage.Text, out code);

            Language language = new Language();
            language.LanguageName = name;
            language.LanguageCode = code;

            languagesBusiness.Add(language);
            UpdateGridLanguage();
            ClearTextBoxesLanguage();
        }
        private void ClearTextBoxesLanguage()
        {
            textBoxNameLanguage.Text = "";
            textBoxCodeLanguage.Text = "";
        }
        private void UpdateGridLanguage()
        {
            dataGridViewTables.DataSource = languagesBusiness.GetAll();
            dataGridViewTables.ReadOnly = true;
            dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateTextboxesLanguage(int id)
        {
            Language update = languagesBusiness.Get(id);
            textBoxNameLanguage.Text = update.LanguageName;
            textBoxCodeLanguage.Text = update.LanguageCode.ToString();
        }
        private void ToggleSaveUpdateLanguage()
        {
            if (buttonUpdateLanguage.Visible)
            {
                buttonSaveLanguage.Visible = true;
                buttonUpdateLanguage.Visible = false;
            }
            else
            {
                buttonSaveLanguage.Visible = false;
                buttonUpdateLanguage.Visible = true;
            }
        }

        private Language GetEditedLanguage()
        {
            Language language = new Language();
            language.LanguageId = editIdLanguage;

            var name = textBoxNameLanguage.Text;
            int code = 0;
            int.TryParse(textBoxCodeLanguage.Text, out code);
            language.LanguageName = name;
            language.LanguageCode = code;

            return language;
        }

        private void buttonDeletePublisher_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                publishersBusiness.DeletePublishers(id);
                UpdateGridPublisher();
                ResetSelect();
            }
        }

        private void buttonUpdatePublisher_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editIdPublisher = id;
                UpdateTextboxesPublisher(id);
                ToggleSaveUpdatePublisher();
                DisableSelect();
            }
        }

        private void buttonSavePublisher_Click(object sender, EventArgs e)
        {
            Publisher editedPublisher = GetEditedPublisher();
            publishersBusiness.UpdatePublishers(editedPublisher);
            UpdateGridPublisher();
            ResetSelect();
            ToggleSaveUpdatePublisher();
        }

        private void buttonInsertPublisher_Click(object sender, EventArgs e)
        {
            var name = textBoxNamePublisher.Text;

            Publisher publisher = new Publisher();
            publisher.PublisherName = name;

            publishersBusiness.AddPublishers(publisher);
            UpdateGridPublisher();
            ClearTextBoxesPublisher();
        }
        private void ClearTextBoxesPublisher()
        {
            textBoxNamePublisher.Text = "";
        }
        private void UpdateGridPublisher()
        {
            dataGridViewTables.DataSource = publishersBusiness.GetAllPublishers();
            dataGridViewTables.ReadOnly = true;
            dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateTextboxesPublisher(int id)
        {
            Publisher update = publishersBusiness.GetPublishers(id);
            textBoxNamePublisher.Text = update.PublisherName;
        }
        private void ToggleSaveUpdatePublisher()
        {
            if (buttonUpdatePublisher.Visible)
            {
                buttonSavePublisher.Visible = true;
                buttonUpdatePublisher.Visible = false;
            }
            else
            {
                buttonSavePublisher.Visible = false;
                buttonUpdatePublisher.Visible = true;
            }
        }

        private Publisher GetEditedPublisher()
        {
            Publisher publisher = new Publisher();
            publisher.PublisherId = editIdPublisher;

            var name = textBoxNamePublisher.Text;
            publisher.PublisherName = name;

            return publisher;
        }

        private void buttonDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                genresBusiness.Delete(id);
                UpdateGridGenre();
                ResetSelect();
            }
        }

        private void buttonUpdateGenre_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var item = dataGridViewTables.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editIdGenre = id;
                UpdateTextboxesGenre(id);
                ToggleSaveUpdateGenre();
                DisableSelect();
            }
        }

        private void buttonSaveGenre_Click(object sender, EventArgs e)
        {
            Genre editedGenre = GetEditedGenre();
            genresBusiness.Update(editedGenre);
            UpdateGridGenre();
            ResetSelect();
            ToggleSaveUpdateGenre();
        }

        private void buttonInsertGenre_Click(object sender, EventArgs e)
        {
            var name = textBoxGenreName.Text;

            Genre genre = new Genre();
            genre.GenreName = name;

            genresBusiness.Add(genre);
            UpdateGridGenre();
            ClearTextBoxesGenre();
        }
        private void ClearTextBoxesGenre()
        {
            textBoxGenreName.Text = "";
        }
        private void UpdateGridGenre()
        {
            dataGridViewTables.DataSource = genresBusiness.GetAll();
            dataGridViewTables.ReadOnly = true;
            dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void UpdateTextboxesGenre(int id)
        {
            Genre update = genresBusiness.Get(id);
            textBoxGenreName.Text = update.GenreName;
        }
        private void ToggleSaveUpdateGenre()
        {
            if (buttonUpdateGenre.Visible)
            {
                buttonSaveGenre.Visible = true;
                buttonUpdateGenre.Visible = false;
            }
            else
            {
                buttonSaveGenre.Visible = false;
                buttonUpdateGenre.Visible = true;
            }
        }

        private Genre GetEditedGenre()
        {
            Genre genre = new Genre();
            genre.GenreId = editIdGenre;

            var name = textBoxGenreName.Text;
            genre.GenreName = name;

            return genre;
        }

        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            Genres();
            Languages();
            Authors();
            Nationalities();
            Publishers();
            //BooksAuthors();
            Books();
            improveOurCatalog.UpdateGridGenre();
            improveOurCatalog.UpdateGridLanguage();
            improveOurCatalog.UpdateGridAuthor();
            improveOurCatalog.UpdateGridNationality();
            improveOurCatalog.UpdateGridPublisher();
            improveOurCatalog.UpdateGridBook();
        }
        private void Genres()
        {
            Genre genreOne = new Genre("classic");
            genresBusiness.Add(genreOne);
            Genre genreTwo = new Genre("fiction");
            genresBusiness.Add(genreTwo);
            Genre genreThree = new Genre("romance");
            genresBusiness.Add(genreThree);
            Genre genreFour = new Genre("science fiction");
            genresBusiness.Add(genreFour);
            Genre genreFive = new Genre("dystopian fiction");
            genresBusiness.Add(genreFive);
            Genre genreSix = new Genre("drama");
            genresBusiness.Add(genreSix);
            Genre genreSeven = new Genre("satire");
            genresBusiness.Add(genreSeven);
            Genre genreEight = new Genre("fragmentary novel");
            genresBusiness.Add(genreEight);
        }
        private void Languages()
        {
            Language languageOne = new Language("english", 44);
            languagesBusiness.Add(languageOne);
            Language languageTwo = new Language("russian", 7);
            languagesBusiness.Add(languageTwo);
            Language languageThree = new Language("bulgarian", 359);
            languagesBusiness.Add(languageThree);
            Language languageFour = new Language("french", 33);
            languagesBusiness.Add(languageFour);
            Language languageFive = new Language("germany", 49);
            languagesBusiness.Add(languageFive);
        }
        private void Authors()
        {
            Author authorOne = new Author("Laini Taylor", 1);
            bussinessAuthors.Add(authorOne);
            Author authorTwo = new Author("Cassandra Clare", 1);
            bussinessAuthors.Add(authorTwo);
            Author authorThree = new Author("Jennifer Lynn Armentrout", 1);
            bussinessAuthors.Add(authorThree);
            Author authorFour = new Author("Chloe Gong", 1);
            bussinessAuthors.Add(authorFour);
            Author authorFive = new Author("Brandon Sanderson", 1);
            bussinessAuthors.Add(authorFive);
            Author authorSix = new Author("Yordan Radichkov", 1);
            bussinessAuthors.Add(authorSix);
        }
        private void Nationalities()
        {
            Nationality nationalitieOne = new Nationality("American");
            businessNationalities.AddNationality(nationalitieOne);
            Nationality nationalitieTwo = new Nationality("Bulgarian");
            businessNationalities.AddNationality(nationalitieTwo);
            Nationality nationalitieThree = new Nationality("New Zealand");
            businessNationalities.AddNationality(nationalitieThree);
            Nationality nationalitieFour = new Nationality("Iranian");
            businessNationalities.AddNationality(nationalitieFour);
            Nationality nationalitieFive = new Nationality("Russian");
            businessNationalities.AddNationality(nationalitieFive);

        }
        private void Publishers()
        {
            Publisher publisherOne = new Publisher("LiterNet");
            publishersBusiness.AddPublishers(publisherOne);
            Publisher publisherTwo = new Publisher("Soft-press");
            publishersBusiness.AddPublishers(publisherTwo);
            Publisher publisherThree = new Publisher("Infodar");
            publishersBusiness.AddPublishers(publisherThree);
            Publisher publisherFour = new Publisher("Alexsoft");
            publishersBusiness.AddPublishers(publisherFour);
        }
        private void Books()
        {
            bookBusiness.InsertInitialData();
        }
        private void BooksAuthors()
        {
            BookAuthor bookAuthorOne = new BookAuthor(1, 1);
            booksAuthorsBusiness.AddBooksAuthors(bookAuthorOne);
            BookAuthor bookAuthorTwo = new BookAuthor(2, 2);
            booksAuthorsBusiness.AddBooksAuthors(bookAuthorTwo);
            BookAuthor bookAuthorThree = new BookAuthor(3, 3);
            booksAuthorsBusiness.AddBooksAuthors(bookAuthorThree);
            BookAuthor bookAuthorFour = new BookAuthor(4, 4);
            booksAuthorsBusiness.AddBooksAuthors(bookAuthorFour);
            BookAuthor bookAuthorFive = new BookAuthor(5, 5);
            booksAuthorsBusiness.AddBooksAuthors(bookAuthorFive);
        }
        
    }
}
