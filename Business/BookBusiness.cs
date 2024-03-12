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

        public List<Book> GetBooksByAuthor(string author)
        {
            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                    .Where(b => b.BookAuthor.Author.Name == author)
                    .Include(e => e.Genre)
                    .Include(e => e.Publisher)
                    .Include(e => e.Language)
                    .ToList();
            }
        }

        public List<Book> GetBooksByGenre(string genre)
        {
            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                    .Where(b => b.Genre.GenreName == genre)
                    .Include(e => e.Genre)
                    .Include(e => e.Publisher)
                    .Include(e => e.Language)
                    .ToList();
            }
        }

        public List<Book> GetBooksByPublisher(string publisher)
        {
            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                    .Where(b => b.Publisher.PublisherName == publisher)
                    .Include(e => e.Genre)
                    .Include(e => e.Publisher)
                    .Include(e => e.Language)
                    .ToList();
            }
        }

        public List<Book> GetBooksByLanguage(string language)
        {
            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                    .Where(b => b.Language.LanguageName == language)
                    .Include(e => e.Genre)
                    .Include(e => e.Publisher)
                    .Include(e => e.Language)
                    .ToList();
            }
        }

        public Book GetCheapestBook()
        {
            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                Book cheapestBook = bookCatalogContext.Books
                    .OrderBy(b => b.Price)
                    .FirstOrDefault();
                if (cheapestBook != null)
                {
                    return cheapestBook;
                }
                else
                {
                    throw new InvalidOperationException("No books found.");
                }
            }
        }

    }
}
