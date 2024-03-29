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
    public class BusinessNationalities
    {
        private BookCatalogContext bookCatalogContext;

        public List<Nationality> GetAllNationalities()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Nationalities.ToList();
            }
        }

        public Nationality GetNationaly(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Nationalities.Find(id);
            }
        }

        public void AddNationality(Nationality nationalities)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                if (!bookCatalogContext.Nationalities.Where(x => x.Name == nationalities.Name).Any())
                {
                    bookCatalogContext.Nationalities.Add(nationalities);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void UpdateNationality(Nationality nationalities)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Nationality item = bookCatalogContext.Nationalities.Find(nationalities.NationalityId);

                if (item != null)
                {
                    bookCatalogContext.Entry(item).CurrentValues.SetValues(nationalities);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public void DeleteNationality(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Nationality nationalities = bookCatalogContext.Nationalities.Find(id);

                if (nationalities != null)
                {
                    bookCatalogContext.Nationalities.Remove(nationalities);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

        public int GetByName(string name)
        {
            List<Nationality> nationalities = this.GetAllNationalities();
            int id = 0;

            foreach (Nationality nationality in nationalities)
            {
                if (nationality.Name == name)
                {
                    id = nationality.NationalityId;
                }
            }
            return id;
        }
    }
}
