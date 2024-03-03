﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        protected override void OnConfiguring
            (DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string conectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
            dbContextOptionsBuilder.UseSqlServer(conectionString);
        }
    }
}
