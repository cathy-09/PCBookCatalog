using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Business;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace TestProject
{
    public class TestAuthor
    {
        private BussinessAuthors bussinessAuthors;
        [SetUp]
        public void Setup()
        {
            bussinessAuthors = new BussinessAuthors();
        }
        [Test]
        public void GetAll_ReturnsAllAuthors()
        {
            BussinessAuthors bussinessAuthors = new BussinessAuthors();
            List<Author> result = bussinessAuthors.GetAll();
            Assert.AreEqual(result.Count, result.Count);
        }
        [Test]
        public void Get_AuthorsById()
        {
            BussinessAuthors bussinessAuthors = new BussinessAuthors();
            int id = 2;
            Author result = bussinessAuthors.Get(id);
            Assert.NotNull(result);
            Assert.AreEqual(id, result.AuthorId);
        }
        [Test]
        public void Add_NewAuthor()
        {
            BussinessAuthors bussinessAuthors = new BussinessAuthors();
            Author newAuthorOne = new Author("NameOne", 1);
            Author newAuthorTwo = new Author("NameTwo", 2);
            bussinessAuthors.Add(newAuthorOne);
            bussinessAuthors.Add(newAuthorTwo);
            int id = bussinessAuthors.GetByName(newAuthorOne.Name);
            Author result = bussinessAuthors.Get(id);
            Assert.AreEqual("NameOne", result.Name);
        }
        [Test]
        public void Update_UpdatesExistingAuthor()
        {
            BussinessAuthors bussinessAuthors = new BussinessAuthors();
            int id = bussinessAuthors.GetByName("NameOne");
            var genreToUpdate = bussinessAuthors.Get(id);
            genreToUpdate.Name = "Updated NameOne";
            bussinessAuthors.Update(genreToUpdate);
            var result = bussinessAuthors.Get(id);
            Assert.AreEqual("Updated NameOne", result.Name);
        }
        [Test]
        public void Delete_ActorById() 
        { 
            BussinessAuthors bussinessAuthors = new BussinessAuthors();
            int id = bussinessAuthors.GetByName("NameOne");
            bussinessAuthors.Delete(id);
            Author result = bussinessAuthors.Get(id);
            Assert.Null(result);
        }
    }
}
