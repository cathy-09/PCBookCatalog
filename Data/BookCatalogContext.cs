using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookCatalogContext : DbContext
    {
        public BookCatalogContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookAuthor> BooksAuthors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookPlaceholder> BookPlaceholders { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string conectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCatalog;Integrated Security=True";
            dbContextOptionsBuilder.UseSqlServer(conectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ep => new { ep.BookId, ep.AuthorId });
        }
    }
}
