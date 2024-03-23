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

        public List<BookPlaceholder> GetAll()
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

        public BookPlaceholder ToBookPlaceholder(Book book)
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

        public BookPlaceholder GetBookPlaceholder(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.BookPlaceholders.Find(id);
            }
        }

        public List<Book> GetBook(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                    .Where(x => x.Id == id)
                    .Include(book => book.Genre)
                    .Include(book => book.Author)
                        .ThenInclude(author => author.Nationality)
                    .Include(book => book.Language)
                    .Include(book => book.Publisher)
                    .ToList();
            }
        }

        public void Add(Book book)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                if (bookCatalogContext.Books.Where(x => x.ISBN == book.ISBN) == null)
                {
                    bookCatalogContext.Books.Add(book);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void Update(Book book)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                var temp = bookCatalogContext.Books
                .FirstOrDefault(x => x.Id == book.Id);

                if (temp != null)
                {
                    // Detach the entity from the context
                    bookCatalogContext.Entry(temp).State = EntityState.Detached;

                    // Make changes to the detached entity
                    temp.Author = book.Author;
                    temp.Language = book.Language;
                    temp.Publisher = book.Publisher;
                    temp.Genre = book.Genre;
                    temp.Price = book.Price;
                    temp.Pages = book.Pages;
                    temp.ISBN = book.ISBN;
                    temp.Name = book.Name;
                    temp.PublicationYear = book.PublicationYear;
                    temp.Rating = book.Rating;
                    // Update other properties as needed

                    // Re-attach the entity and mark it as modified
                    bookCatalogContext.Attach(temp);
                    bookCatalogContext.Entry(temp).State = EntityState.Modified;

                    // Save changes
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
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

        public List<BookPlaceholder> GetBooksSortedByTitle()
        {
            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Books
                    .OrderBy(b => b.Name)
                    .Include(e => e.Genre)
                    .Include(e => e.Publisher)
                    .Include(e => e.Language)
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

        public void InsertInitialData()
        {
            Book book1 = new Book
            {
                Name = "The Magicians' Guild",
                Author = new Author { Name = "Trudi Canavan (Australian)", Nationality = new Nationality { Name = "Australian" } },
                Genre = new Genre { GenreName = "Fantasy" },
                Publisher = new Publisher { PublisherName = "MBG Books" },
                Rating = 3.95,
                Pages = 440,
                Price = 15.90m,
                ISBN = "9789542989011",
                PublicationYear = 2011,
                Language = new Language { LanguageName = "English" }
            };

            Book book2 = new Book
            {
                Name = "Shatter Me",
                Author = new Author { Name = "Tahereh Mafi(Iranian)", Nationality = new Nationality { Name = "Iranian" } },
                Genre = new Genre { GenreName = "Dystopian fiction" },
                Publisher = new Publisher { PublisherName = "Egmont" },
                Rating = 3.86,
                Pages = 328,
                Price = 19.90m,
                ISBN = "9789542713760",
                PublicationYear = 2015,
                Language = new Language { LanguageName = "English" }
            };

            Book book3 = new Book
            {
                Name = "Crime and Punishment",
                Author = new Author { Name = "Fyodor Dostoevsky(Russian)", Nationality = new Nationality { Name = "Russian" } },
                Genre = new Genre { GenreName = "classic" },
                Publisher = new Publisher { PublisherName = "Zahariy Stoyanov" },
                Rating = 4.27,
                Pages = 512,
                Price = 30.00m,
                ISBN = "978954091017Х",
                PublicationYear = 2011,
                Language = new Language { LanguageName = "Russian" }
            };

            Book book4 = new Book
            {
                Name = "War and Peace",
                Author = new Author { Name = "Leo Tolstoy(Russian)", Nationality = new Nationality { Name = "Russian" } },
                Genre = new Genre { GenreName = "classic" },
                Publisher = new Publisher { PublisherName = "Kryg" },
                Rating = 4.16,
                Pages = 516,
                Price = 19.00m,
                ISBN = "9786197625349",
                PublicationYear = 2021,
                Language = new Language { LanguageName = "Russian" }
            };

            Book book5 = new Book
            {
                Name = "Throne of Glass",
                Author = new Author { Name = "Sarah J. Maas(American)", Nationality = new Nationality { Name = "American" } },
                Genre = new Genre { GenreName = "fantasy" },
                Publisher = new Publisher { PublisherName = "Egmont" },
                Rating = 4.17,
                Pages = 400,
                Price = 19.90m,
                ISBN = "9789542711667",
                PublicationYear = 2020,
                Language = new Language { LanguageName = "English" }
            };

            Book book6 = new Book
            {
                Name = "Vicious",
                Author = new Author { Name = "V. E. Schwab(American)", Nationality = new Nationality { Name = "American" } },
                Genre = new Genre { GenreName = "fantasy" },
                Publisher = new Publisher { PublisherName = "Emas" },
                Rating = 4.21,
                Pages = 376,
                Price = 19.00m,
                ISBN = "9789543575084",
                PublicationYear = 2021,
                Language = new Language { LanguageName = "English" }
            };

            Book book7 = new Book
            {
                Name = "Six of Crows",
                Author = new Author { Name = "Leigh Bardugo(American)", Nationality = new Nationality { Name = "American" } },
                Genre = new Genre { GenreName = "fantasy" },
                Publisher = new Publisher { PublisherName = "Egmont" },
                Rating = 4.49,
                Pages = 560,
                Price = 19.90m,
                ISBN = "9789542723028",
                PublicationYear = 2019,
                Language = new Language { LanguageName = "English" }
            };

            using (BookCatalogContext bookCatalogContext = new BookCatalogContext())
            {
                if (bookCatalogContext.Books.Where(x => x.ISBN == book1.ISBN) == null)
                {
                    bookCatalogContext.Books.Add(book1);
                    bookCatalogContext.Books.Add(book2);
                    bookCatalogContext.Books.Add(book3);
                    bookCatalogContext.Books.Add(book4);
                    bookCatalogContext.Books.Add(book5);
                    bookCatalogContext.Books.Add(book6);
                    bookCatalogContext.Books.Add(book7);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
    }
}

