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
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.Genre)
                .Include(b => b.Publisher)
                .Include(b => b.Language)
                .ToList();
                //bookCatalogContext.Books
                //    .Include(f => f.BookAuthors)
                //    .ThenInclude(a => a.Author)
                //    .ToList();
                //return bookCatalogContext.Books.Include(g => g.Genre).Include(b => b.Publisher).Include(c => c.Language).ToList();
                //var withGenre = bookCatalogContext.Books
                //    .Include(e => e.Genre)
                //    .ThenInclude(e => e.GenreName);
                //var withPublisher = withGenre
                //    .Include(e => e.Publisher)
                //    .ThenInclude(e => e.PublisherName);
                //var withAuthor = withPublisher
                //    .Include(e => e.Author)
                //    .ThenInclude(e => e.Name);
                //var withLanguage = withAuthor
                //    .Include(e => e.Language)
                //    .ThenInclude(e => e.LanguageName);
                //return withLanguage.ToList();
                //return bookCatalogContext.Books
                //.Include(e => e.Genre.GenreName)
                //.Include(e => e.Publisher.PublisherName)
                //.Include(e => e.Language.LanguageName)
                //.Include(e => e.Author.Name)
                //.ToList();
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
                    .Where(b => b.Author.Name == author)
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
        public void InsertInitialData()
        {
            // Първа книга
            Book book1 = new Book
            {
                Name = "The Magicians' Guild",
                Author = new Author { Name =  "Trudi Canavan (Australian)" },
                Genre = new Genre { GenreName = "Fantasy" },
                Publisher = new Publisher { PublisherName = "MBG Books" },
                Rating = 3.95,
                Pages = 440,
                Price = 15.90m,
                ISBN = "9789542989011",
                PublicationYear = 2011,
                Language = new Language { LanguageName = "English" }
            };

            // Добавяне на книгите към базата данни
            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Books.Add(book1);
                bookCatalogContext.SaveChanges();
            }
        }
    }
}
