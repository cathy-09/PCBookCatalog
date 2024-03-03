using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class BusinessNationalities
    {
        private BookCatalogContext bookCatalogContext;
        public List<Nationalities> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Nationalities.ToList();
            }
        }
        public Nationalities Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Nationalities.Find(id);
            }
        }
        public void Add(Nationalities nationalities)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Nationalities.Add(nationalities);
                bookCatalogContext.SaveChanges();
            }
        }
        public void Update(Nationalities nationalities)
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
        public void Delete(int id)
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
