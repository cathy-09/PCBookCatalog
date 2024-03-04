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

        public List<Language> GetAll()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Languages.ToList();
            }
        }
        public Language Get(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Languages.Find(id);
            }
        }
        public void Add(Language languages)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Languages.Add(languages);
                bookCatalogContext.SaveChanges();
            }
        }
        public void Update(Language languages)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Language item = bookCatalogContext.Languages.Find(languages.LanguageId);
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
                Language languages = bookCatalogContext.Languages.Find(id);
                if (languages != null)
                {
                    bookCatalogContext.Languages.Remove(languages);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

    }
}
