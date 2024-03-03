﻿using Data.Models;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    /// <summary>
    /// Represents the set of functionality of the GUI elements at program startup
    /// </summary>
    public class BussinessAuthors
    {
        private BookCatalogContext bookCatalogContext;

        /// <summary>
        /// Gets all authors from database
        /// </summary>

        public List<Authors> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.Include(e => e.Nationalities).ToList();
            }
        }

        /// <summary>
        /// Gets an author by id from database
        /// </summary>

        public Authors Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.Find(id);
            }
        }

        /// <summary>
        /// Adds an author to the current context
        /// </summary>

        public void Add(Authors authors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Authors.Add(authors);
                bookCatalogContext.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an author to the current context
        /// </summary>

        public void Update(Authors authors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Authors item = bookCatalogContext.Authors.Find(authors.AuthorId);
                if (item != null)
                {
                    bookCatalogContext.Entry(item).CurrentValues.SetValues(authors);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deletes an author to the current context
        /// </summary>

        public void Delete(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Authors authors = bookCatalogContext.Authors.Find(id);
                if (authors != null)
                {
                    bookCatalogContext.Authors.Remove(authors);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
    }
}