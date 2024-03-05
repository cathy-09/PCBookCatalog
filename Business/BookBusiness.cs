using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class BookBusiness
    {
        private BookCatalogContext bookCatalogContext;

        public List<Book> GetAll ()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                    .Include(e => e.Genre)
                    .Include(e => e.Publisher)
                    .Include(e => e.Language)
                    .ToList();
            }
        }

        public Book Get (int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books.Find(id);
            }
        }

        public void Add (Book book)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                if (!bookCatalogContext.Books.Contains(book))
                {
                    bookCatalogContext.Books.Add(book);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void Update (Book book)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Book temp = bookCatalogContext.Books.Find(book.Id);
                if (temp != null)
                {
                    bookCatalogContext.Entry(temp).CurrentValues.SetValues(book);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void Delete (int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Book temp = bookCatalogContext.Books.Find(id);
                if (temp != null)
                {
                    bookCatalogContext.Books.Remove(temp);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
    }
}
