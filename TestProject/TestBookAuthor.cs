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
    public class TestBookAuthor
    {
        private BookAuthorsBusiness bookAuthorsBusiness;
        [SetUp]
        public void Setup()
        {
            bookAuthorsBusiness = new BookAuthorsBusiness();
        }
        [Test]
        public void GetAll_AllBooksAuthors()
        {
            BookAuthorsBusiness bookAuthorsBusiness = new BookAuthorsBusiness();
            List<BookAuthor> result = bookAuthorsBusiness.GetAllBooksAuthors();
            Assert.AreEqual(result.Count, result.Count);
        }
        [Test]
        public void Get_BooksAuthorsById()
        {
            BookAuthorsBusiness bookAuthorsBusiness = new BookAuthorsBusiness();
            int bookId = 2;
            int authorId = 5;
            BookAuthor result = bookAuthorsBusiness.GetBooksAuthors(bookId, authorId);
            Assert.NotNull(result);
            Assert.AreEqual(bookId, result.BookId);
            Assert.AreEqual(authorId, result.AuthorId);
        }
        [Test]
        public void Add_NewBooksAuthors()
        {
            BookAuthorsBusiness bookAuthorsBusiness = new BookAuthorsBusiness();
            BookAuthor newBookAuthorOne = new BookAuthor(2, 5);
            BookAuthor newBookAuthorTwo = new BookAuthor(2, 3);
            bookAuthorsBusiness.AddBooksAuthors(newBookAuthorOne);
            bookAuthorsBusiness.AddBooksAuthors(newBookAuthorTwo);
            int bookIdOne = bookAuthorsBusiness.GetBookIdByAuthorId(newBookAuthorOne.AuthorId);
            int authorIdOne = newBookAuthorOne.AuthorId;
            BookAuthor resultOne = bookAuthorsBusiness.GetBooksAuthors(bookIdOne, authorIdOne);
            Assert.AreEqual(newBookAuthorOne.BookId, resultOne.BookId);
            Assert.AreEqual(newBookAuthorOne.AuthorId, resultOne.AuthorId);
            int bookIdTwo = bookAuthorsBusiness.GetBookIdByAuthorId(newBookAuthorTwo.AuthorId);
            int authorIdTwo = newBookAuthorTwo.AuthorId;
            BookAuthor resultTwo = bookAuthorsBusiness.GetBooksAuthors(bookIdTwo, authorIdTwo);
            Assert.AreEqual(newBookAuthorTwo.BookId, resultTwo.BookId);
            Assert.AreEqual(newBookAuthorTwo.AuthorId, resultTwo.AuthorId);
        }
        [Test]
        public void Update_UpdatesExistingBooksAuthors()
        {
            int bookId = 1;
            int authorId = 2;
            BookAuthorsBusiness bookAuthorsBusiness = new BookAuthorsBusiness();
            BookAuthor bookAuthorToUpdate = bookAuthorsBusiness.GetBooksAuthors(bookId, authorId);
            if (bookAuthorToUpdate != null)
            {
                bookAuthorToUpdate.BookId = 5;
                bookAuthorToUpdate.AuthorId = 4;
                bookAuthorsBusiness.UpdateBooksAuthors(bookAuthorToUpdate);
                BookAuthor updatedBookAuthor = bookAuthorsBusiness.GetBooksAuthors(bookAuthorToUpdate.BookId, bookAuthorToUpdate.AuthorId);
                Assert.IsNotNull(updatedBookAuthor, "Yes.");
                Assert.AreEqual(5, updatedBookAuthor.BookId, "BookId No");
                Assert.AreEqual(4, updatedBookAuthor.AuthorId, "AuthorId No");
            }
            else
            {
                Assert.Fail("No");
            }
        }
        [Test]
        public void Delete_BooksAuthorsById()
        {
            BookAuthorsBusiness bookAuthorsBusiness = new BookAuthorsBusiness();
            int bookId = 2;
            int authorId = 3;
            bookAuthorsBusiness.DeleteBooksAuthors(bookId, authorId);
            BookAuthor result = bookAuthorsBusiness.GetBooksAuthors(bookId, authorId);
            Assert.Null(result, "Връзката между книгата и автора не е изтрита успешно.");
        }
    }
}
