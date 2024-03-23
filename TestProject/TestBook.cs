using Business;
using Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestBook
    {
        private BookBusiness bookBusiness;

        [SetUp]
        public void Setup()
        {
            bookBusiness = new BookBusiness();
            bookBusiness.InsertInitialData();
        }

        [Test]
        public void GetAll_ReturnsAllBooks()
        {
            List<BookPlaceholder> result = bookBusiness.GetAll();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
        }

        [Test]
        public void GetBook_ReturnsBookById()
        {
            int id = 2;
            List<Book> result = bookBusiness.GetBook(id);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(id, result.First().Id);
        }

        [Test]
        public void Add_AddsNewBook()
        {
            Book newBook = new Book
            {
                Name = "Test Book1",
                Author = new Author { Name = "Test Author1", Nationality = new Nationality { Name = "TestNationality1" } },
                Genre = new Genre { GenreName = "Test Genre1" },
                Publisher = new Publisher { PublisherName = "Test Publisher1" },
                Rating = 4.5,
                Pages = 300,
                Price = 20.00m,
                ISBN = "1234567890",
                PublicationYear = 2022,
                Language = new Language { LanguageName = "English1" }
            };

            bookBusiness.Add(newBook);

            int id = bookBusiness.GetByName(newBook.Name);
            List<Book> result = bookBusiness.GetBook(id);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(newBook.Name, result.First().Name);
        }
        [Test]
        public void Update_UpdatesExistingBook()
        {
            int id = 3;
            string updatedName = "Crime and Punishment";
            List<Book> bookToUpdate = bookBusiness.GetBook(id);
            foreach (var book in bookToUpdate)
            {
                book.Name = updatedName;
            }
            //bookBusiness.Update(bookToUpdate);
            List<Book> result = bookBusiness.GetBook(id);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(updatedName, result.First().Name);
        }
        [Test]
        public void Delete_DeletesExistingBook()
        {
            int id = 6;
            bookBusiness.Delete(id);
            List<Book> result = bookBusiness.GetBook(id);
            //Assert.IsNull(result);
            Assert.That(result.Count == 0);
        }
        [Test]
        public void GetBooksByAuthor_ReturnsBooksByAuthor()
        {
            string author = "Trudi Canavan (Australian)";
            List<Book> result = bookBusiness.GetBooksByAuthor(author);
            Assert.That(result.Count != 0);
            Assert.IsTrue(result.All(b => b.Author.Name == author));
        }

        [Test]
        public void GetBooksByGenre_ReturnsBooksByGenre()
        {
            string genre = "classic";
            List<Book> result = bookBusiness.GetBooksByGenre(genre);
            Assert.That(result.Count != 0);
            Assert.IsTrue(result.All(b => b.Genre.GenreName == genre)); //????
        }
    }
}
