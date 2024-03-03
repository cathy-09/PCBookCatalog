using Data.Models;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LanguagesBusiness
    {
        private BookCatalogContext bookCatalogContext;

        public List<Languages> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Languages.ToList();
            }
        }
        public Languages Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Languages.Find(id);
            }
        }
        public void Add(Languages languages)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Languages.Add(languages);
                bookCatalogContext.SaveChanges();
            }
        }
        public void Update(Languages languages)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Languages item = bookCatalogContext.Languages.Find(languages.LanguagesId);
                if (item != null)
                {
                    bookCatalogContext.Entry(item).CurrentValues.SetValues(languages);
                    bookCatalogContext.SaveChanges();
                }
            }

        }
        public void Delete(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Languages languages = bookCatalogContext.Languages.Find(id);
                if (languages != null)
                {
                    bookCatalogContext.Languages.Remove(languages);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

    }
}
