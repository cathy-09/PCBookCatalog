﻿using Data;
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

        public List<Genre> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Genres.ToList();
            }
        }

        public Genre Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Genres.Find(id);
            }
        }

        public void Add(Genre genres)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                if (!bookCatalogContext.Genres.Where(x => x.GenreName == genres.GenreName).Any())
                {
                    bookCatalogContext.Genres.Add(genres);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void Update(Genre genres)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Genre item = bookCatalogContext.Genres.Find(genres.GenreId);

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
                Genre genres = bookCatalogContext.Genres.Find(id);

                if (genres != null)
                {
                    bookCatalogContext.Genres.Remove(genres);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
        public int GetByName(string name)
        {
            List<Genre> genres = this.GetAll();
            int id = 0;

            foreach (Genre genre in genres)
            {
                if (genre.GenreName == name)
                {
                    id = genre.GenreId;
                }
            }
            return id;
        }
    }
}
