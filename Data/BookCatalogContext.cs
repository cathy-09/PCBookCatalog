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
        public DbSet<Nationalities> Nationalities { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<BooksAuthors> BooksAuthors { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string conectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookCatalog;Integrated Security=True";
            dbContextOptionsBuilder.UseSqlServer(conectionString);
        }
    }
}
