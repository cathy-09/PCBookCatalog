using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookAuthorsBusiness
    {
        private BookCatalogContext bookCatalogContext;

        public List<BookAuthor> GetAllBooksAuthors()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.BooksAuthors.Include(e => e.Author).ToList();
            }
        }

        public BookAuthor GetBooksAuthors(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.BooksAuthors.Find(id);
            }
        }

        public void AddBooksAuthors(BookAuthor booksAuthors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                //if (bookCatalogContext.BooksAuthors.Where(x => x.AuthorId == booksAuthors.AuthorId && x.BookId == booksAuthors.BookId) == null)
                //{
                    bookCatalogContext.BooksAuthors.Add(booksAuthors);
                    bookCatalogContext.SaveChanges();
                //}
            }
        }

        public void UpdateBooksAuthors(BookAuthor booksAuthors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                BookAuthor item = bookCatalogContext.BooksAuthors.Find(booksAuthors.BookId, booksAuthors.AuthorId);
                if (item != null)
                {
                    bookCatalogContext.Entry(item).CurrentValues.SetValues(booksAuthors);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void DeleteBooksAuthors(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                BookAuthor booksAuthors = bookCatalogContext.BooksAuthors.Find(id);
                if (booksAuthors != null)
                {
                    bookCatalogContext.BooksAuthors.Remove(booksAuthors);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

    }
}
