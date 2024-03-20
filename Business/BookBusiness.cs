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

        public List<BookPlaceholder> GetAll ()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                .Include(book => book.Genre)
                .Include(book => book.Author)
                .Include(book => book.Language)
                .Include(book => book.Publisher)
                .Select(book => new BookPlaceholder
                {
                    Id = book.Id,
                    Name = book.Name,
                    Author = book.Author.Name,
                    Genre = book.Genre.GenreName,
                    Publisher = book.Publisher.PublisherName,
                    Rating = book.Rating,
                    Pages = book.Pages,
                    Price = book.Price,
                    ISBN = book.ISBN,
                    PublicationYear = book.PublicationYear,
                    Language = book.Language.LanguageName
                })
                .ToList();
            }
        }

        public BookPlaceholder toBookPlaceholder(Book book)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                BookPlaceholder bookPlaceholder = new BookPlaceholder();
                bookPlaceholder.Name = book.Name;
                bookPlaceholder.ISBN = book.ISBN;
                bookPlaceholder.Author = book.Author.Name;
                bookPlaceholder.Genre = book.Genre.GenreName;
                bookPlaceholder.Publisher = book.Publisher.PublisherName;
                bookPlaceholder.Rating = book.Rating;
                bookPlaceholder.Pages = book.Pages;
                bookPlaceholder.Price = book.Price;
                bookPlaceholder.Language = book.Language.LanguageName; 
                return bookPlaceholder;
            }
        }

        public BookPlaceholder GetBookPlaceholder (int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.BookPlaceholders.Find(id);
            }
        }

        public Book GetBook(int id)
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
            Book book1 = new Book
            {
                Name = "The Magicians' Guild",
                Author = new Author { Name =  "Trudi Canavan (Australian)", Nationality = new Nationality { Name = "Australian" } },
                Genre = new Genre { GenreName = "Fantasy" },
                Publisher = new Publisher { PublisherName = "MBG Books" },
                Rating = 3.95,
                Pages = 440,
                Price = 15.90m,
                ISBN = "9789542989011",
                PublicationYear = 2011,
                Language = new Language { LanguageName = "English" }
            };

            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Books.Add(book1);
                bookCatalogContext.SaveChanges();
            }
        }
    }
}
