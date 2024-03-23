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

        public List<Author> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.ToList();
            }
        }

        public Author Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Authors.Find(id);
            }
        }

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
