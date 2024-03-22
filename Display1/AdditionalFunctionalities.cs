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

namespace Display1
{
    public partial class AdditionalFunctionalities : Form
    {
        public MainForm mainForm;
        public BookBusiness bookBusiness = new BookBusiness();
        public GenresBusiness genresBusiness = new GenresBusiness();
        public AdditionalFunctionalities(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void UpdateGrid()
        {
            dataGridViewAdditional.DataSource = bookBusiness.GetAll();
            dataGridViewAdditional.ReadOnly = true;
            dataGridViewAdditional.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AdditionalFunctionalities_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void buttonGetCheapestBook_Click(object sender, EventArgs e)
        {
            listBoxCheapestBook.Items.Clear();
            Book cheapestBook = bookBusiness.GetCheapestBook();
            if (cheapestBook != null)
            {
                listBoxBooksByAuthor.Items.Add(cheapestBook.Name);
            }
            else
            {
                MessageBox.Show("Няма налични книги.");
            }
        }

        private void buttonBooksByAuthor_Click(object sender, EventArgs e)
        {
            listBoxBooksByAuthor.Items.Clear();
            string authorName = textBoxBooksByAuthor.Text;
            List<Book> books = bookBusiness.GetBooksByAuthor(authorName);
            if (books.Count == 0)
            {
                MessageBox.Show("Няма книги на този автор.");
            }
            else
            {
                foreach (var book in books)
                {
                    listBoxBooksByAuthor.Items.Add(book.Name);
                }
                if (listBoxBooksByAuthor.Items.Count == 0)
                {
                    MessageBox.Show("Няма книги на този автор.");
                }
            }
            textBoxBooksByAuthor.Text = "";
        }

        private void buttonBooksByGenre_Click(object sender, EventArgs e)
        {
            listBoxBooksByGenre.Items.Clear();
            string genre = textBoxBooksByGenre.Text;
            List<Book> books = bookBusiness.GetBooksByGenre(genre);
            if (books.Count == 0)
            {
                MessageBox.Show("Няма книги с този жанр.");
            }
            else
            {
                foreach (var book in books)
                {
                    listBoxBooksByGenre.Items.Add(book.Name);
                }
                if (listBoxBooksByGenre.Items.Count == 0)
                {
                    MessageBox.Show("Няма книги с този жанр.");
                }
            }
            textBoxBooksByGenre.Text = "";
        }

        private void buttonAdditionalGoBackToMain_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            Close();
        }
    }
}
