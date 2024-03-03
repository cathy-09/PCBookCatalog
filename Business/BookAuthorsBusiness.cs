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

        public List<BooksAuthors> GetAllBooksAuthors()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.BooksAuthors.Include(e => e.Authors).ToList();
            }
        }
        public BooksAuthors GetBooksAuthors(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.BooksAuthors.Find(id);
            }
        }
        public void AddBooksAuthors(BooksAuthors booksAuthors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.BooksAuthors.Add(booksAuthors);
                bookCatalogContext.SaveChanges();
            }
        }
        public void UpdateBooksAuthors(BooksAuthors booksAuthors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                BooksAuthors item = bookCatalogContext.BooksAuthors.Find(booksAuthors.BookId, booksAuthors.AuthorId);
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
                BooksAuthors booksAuthors = bookCatalogContext.BooksAuthors.Find(id);
                if (booksAuthors != null)
                {
                    bookCatalogContext.BooksAuthors.Remove(booksAuthors);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
    }
}
