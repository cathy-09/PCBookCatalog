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
    public class TestGenre
    {
        private GenresBusiness genresBusiness;
        [SetUp]
        public void Setup()
        {
            genresBusiness = new GenresBusiness();
        }
        [Test]
        public void GetAll_AllGenres()
        {
            GenresBusiness genresBusiness = new GenresBusiness();
            List<Genre> result = genresBusiness.GetAll();
            Assert.AreEqual(result.Count, result.Count);
        }
        [Test]
        public void Get_GenresById()
        {
            GenresBusiness genresBusiness = new GenresBusiness();
            int id = 2;
            Genre result = genresBusiness.Get(id);
            Assert.NotNull(result);
            Assert.AreEqual(id, result.GenreId);
        }
        [Test]
        public void Add_NewGenres()
        {
            GenresBusiness genresBusiness = new GenresBusiness();
            Genre newGenreOne = new Genre("GenreOne");
            Genre newGenreTwo = new Genre("GenreTwo");
            genresBusiness.Add(newGenreOne);
            genresBusiness.Add(newGenreTwo);
            int id = genresBusiness.GetByName(newGenreOne.GenreName);
            Genre result = genresBusiness.Get(id);
            Assert.AreEqual("GenreOne", result.GenreName);
        }
        [Test]
        public void Update_UpdatesExistingGenres()
        {
            GenresBusiness genresBusiness = new GenresBusiness();
            int id = genresBusiness.GetByName("GenreTwo");
            Genre genreToUpdate = genresBusiness.Get(id);
            genreToUpdate.GenreName = "Updated GenreName";
            genresBusiness.Update(genreToUpdate);
            var result = genresBusiness.Get(id);
            Assert.AreEqual("Updated GenreName", result.GenreName);
        }
        [Test]
        public void Delete_GenresById()
        {
            GenresBusiness genresBusiness = new GenresBusiness();
            int id = genresBusiness.GetByName("GenreOne");
            genresBusiness.Delete(id);
            Genre result = genresBusiness.Get(id);
            Assert.Null(result);
        }
    }
}
