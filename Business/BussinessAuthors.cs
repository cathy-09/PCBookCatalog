using Data.Models;
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

        public List<Author> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.ToList();
            }
        }

        /// <summary>
        /// Gets an author by id from database
        /// </summary>

        public Author Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.Find(id);
            }
        }

        /// <summary>
        /// Adds an author to the current context
        /// </summary>

        public void Add(Author authors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                if (!bookCatalogContext.Authors.Where(x => x.Name == authors.Name).Any())
                {
                    bookCatalogContext.Authors.Add(authors);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Updates an author to the current context
        /// </summary>

        public void Update(Author authors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Author item = bookCatalogContext.Authors.Find(authors.AuthorId);
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
                Author authors = bookCatalogContext.Authors.Find(id);
                if (authors != null)
                {
                    bookCatalogContext.Authors.Remove(authors);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
        public int GetByName(string name)
        {
            List<Author> authors = this.GetAll();
            int id = 0;
            foreach (Author author in authors)
            {
                if (author.Name == name)
                {
                    id = author.AuthorId;
                }
            }
            return id;
        }
    }
}
