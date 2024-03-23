using Business;
using Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestPublisher
    {
        private PublishersBusiness publishersBusiness;
        [SetUp]
        public void Setup()
        {
            publishersBusiness = new PublishersBusiness();
        }
        [Test]
        public void GetAll_AllPublishers()
        {
            PublishersBusiness publishersBusiness = new PublishersBusiness();
            List<Publisher> result = publishersBusiness.GetAllPublishers();
            Assert.AreEqual(result.Count, result.Count);
        }
        [Test]
        public void Get_PublishersById()
        {
            PublishersBusiness publishersBusiness = new PublishersBusiness();
            int id = 2;
            Publisher result = publishersBusiness.GetPublishers(id);
            Assert.NotNull(result);
            Assert.AreEqual(id, result.PublisherId);
        }
        [Test]
        public void Add_NewLanguages()
        {
            PublishersBusiness publishersBusiness = new PublishersBusiness();
            Publisher newPublisherOne = new Publisher("PublisherOne");
            Publisher newPublisherTwo = new Publisher("PublisherTwo");
            publishersBusiness.AddPublishers(newPublisherOne);
            publishersBusiness.AddPublishers(newPublisherTwo);
            int id = publishersBusiness.GetByName(newPublisherOne.PublisherName);
            Publisher result = publishersBusiness.GetPublishers(id);
            Assert.AreEqual("PublisherOne", result.PublisherName);
        }
        [Test]
        public void Update_UpdatesExistingLanguages()
        {
            PublishersBusiness publishersBusiness = new PublishersBusiness();
            int id = publishersBusiness.GetByName("PublisherTwo");
            Publisher publisherToUpdate = publishersBusiness.GetPublishers(id);
            publisherToUpdate.PublisherName = "Updated PublisherName";
            publishersBusiness.UpdatePublishers(publisherToUpdate);
            Publisher result = publishersBusiness.GetPublishers(id);
            Assert.AreEqual("Updated PublisherName", result.PublisherName);
        }
        [Test]
        public void Delete_LanguagesById()
        {
            PublishersBusiness publishersBusiness = new PublishersBusiness();
            int id = publishersBusiness.GetByName("PublisherOne");
            publishersBusiness.DeletePublishers(id);
            Publisher result = publishersBusiness.GetPublishers(id);
            Assert.Null(result);
        }
    }
}
