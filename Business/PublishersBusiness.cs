using Data.Models;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PublishersBusiness
    {
        private BookCatalogContext bookCatalogContext;

        public List<Publishers> GetAllPublishers()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Publishers.ToList();
            }
        }
        public Publishers GetPublishers(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Publishers.Find(id);
            }
        }
        public void AddPublishers(Publishers publishers)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                bookCatalogContext.Publishers.Add(publishers);
                bookCatalogContext.SaveChanges();
            }
        }
        public void UpdatePublishers(Publishers publishers)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Publishers item = bookCatalogContext.Publishers.Find(publishers.PublisherId);
                if (item != null)
                {
                    bookCatalogContext.Entry(item).CurrentValues.SetValues(publishers);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
        public void DeletePublishers(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Publishers publishers = bookCatalogContext.Publishers.Find(id);
                if (publishers != null)
                {
                    bookCatalogContext.Publishers.Remove(publishers);
                    bookCatalogContext.SaveChanges();
                }
            }
        }
    }
}
