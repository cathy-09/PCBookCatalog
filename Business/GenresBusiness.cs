using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GenresBusiness
    {
        private BookCatalogContext bookCatalogContext;

        public List<Genres> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Genres.ToList();
            }
        }
        public Genres Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Genres.Find(id);
            }
        }
        public void Add(Genres genres)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Genres.Add(genres);
                bookCatalogContext.SaveChanges();
            }
        }
        public void Update(Genres genres)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Genres item = bookCatalogContext.Genres.Find(genres.GenresId);
                if (item != null)
                {
                    bookCatalogContext.Entry(item).CurrentValues.SetValues(genres);
                    bookCatalogContext.SaveChanges();
                }
            }

        }
        public void Delete(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Genres genres = bookCatalogContext.Genres.Find(id);
                if (genres != null)
                {
                    bookCatalogContext.Genres.Remove(genres);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

    }
}
