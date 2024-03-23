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

        public List<Publisher> GetAllPublishers()
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Publishers.ToList();
            }
        }

        public Publisher GetPublishers(int id)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                return bookCatalogContext.Publishers.Find(id);
            }
        }

        public void AddPublishers(Publisher publishers)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                //if (bookCatalogContext.Publishers.Where(x => x.PublisherName == publishers.PublisherName) == null)
                //{
                    bookCatalogContext.Publishers.Add(publishers);
                    bookCatalogContext.SaveChanges();
                //}
            }
        }

        public void UpdatePublishers(Publisher publishers)
        {
            using (bookCatalogContext = new BookCatalogContext())
            {
                Publisher item = bookCatalogContext.Publishers.Find(publishers.PublisherId);
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
                Publisher publishers = bookCatalogContext.Publishers.Find(id);
                if (publishers != null)
                {
                    bookCatalogContext.Publishers.Remove(publishers);
                    bookCatalogContext.SaveChanges();
                }
            }
        }

    }
}
