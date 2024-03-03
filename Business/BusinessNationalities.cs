﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    /// <summary>
    /// Represents the set of functionality of the GUI elements at program startup
    /// </summary>
    public class BusinessNationalities
    {
        private BookCatalogContext bookCatalogContext;

        /// <summary>
        /// Gets all nationalities from database
        /// </summary>

        public List<Nationalities> GetAllNationalities()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Nationalities.ToList();
            }
        }

        /// <summary>
        /// Gets a nationality by id from database
        /// </summary>

        public Nationalities GetNationaly(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Nationalities.Find(id);
            }
        }

        /// <summary>
        /// Adds a nationality to the current context
        /// </summary>

        public void AddNationality(Nationalities nationalities)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Nationalities.Add(nationalities);
                bookCatalogContext.SaveChanges();
            }
        }

        /// <summary>
        /// Updates a nationality to the current context
        /// </summary>

        public void UpdateNationality(Nationalities nationalities)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Nationalities item = bookCatalogContext.Nationalities.Find(nationalities.NationalityId);
                if (item != null)
                {
                    bookCatalogContext.Entry(item).CurrentValues.SetValues(nationalities);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deletes a nationality to the current context
        /// </summary>

        public void DeleteNationality(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Nationalities nationalities = bookCatalogContext.Nationalities.Find(id);
                if (nationalities != null)
                {
                    bookCatalogContext.Nationalities.Remove(nationalities);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
    }
}