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
    public class BussinessAuthors
    {
        private BookCatalogContext bookCatalogContext;
        public List<Authors> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.Include(e => e.Nationalities).ToList();
            }
        }
        public Authors Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.Find(id);
            }
        }
        public void Add(Authors authors)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Authors.Add(authors);
                bookCatalogContext.SaveChanges();
            }
        }
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
