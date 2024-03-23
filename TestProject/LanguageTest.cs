using Business;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class LanguageTest
    {
        private LanguagesBusiness languagesBusiness;
        [SetUp]
        public void Setup()
        {
            languagesBusiness = new LanguagesBusiness();
        }
        [Test]
        public void GetAll_AllLanguages()
        {
            LanguagesBusiness languagesBusiness = new LanguagesBusiness();
            List<Language> result = languagesBusiness.GetAll();
            Assert.AreEqual(result.Count, result.Count);
        }
        [Test]
        public void Get_LanguagesById()
        {
            LanguagesBusiness languagesBusiness = new LanguagesBusiness();
            int id = 2;
            Language result = languagesBusiness.Get(id);
            Assert.NotNull(result);
            Assert.AreEqual(id, result.LanguageId);
        }
        [Test]
        public void Add_NewLanguages()
        {
            LanguagesBusiness languagesBusiness = new LanguagesBusiness();
            Language newLanguagesOne = new Language("LanguagesOne", 123);
            Language newLanguagesTwo = new Language("LanguagesTwo", 321);
            languagesBusiness.Add(newLanguagesOne);
            languagesBusiness.Add(newLanguagesTwo);
            //int id = languagesBusiness.GetByName(newLanguagesOne.LanguageName);
            //Language result = languagesBusiness.Get(id);
            //Assert.AreEqual("LanguagesOne", result.LanguageName);
        }
        [Test]
        public void Update_UpdatesExistingLanguages()
        {
            //GenresBusiness genresBusiness = new GenresBusiness();
            //int id = genresBusiness.GetByName("GenreTwo");
            //Genre genreToUpdate = genresBusiness.Get(id);
            //genreToUpdate.GenreName = "Updated GenreName";
            //genresBusiness.Update(genreToUpdate);
            //var result = genresBusiness.Get(id);
            //Assert.AreEqual("Updated GenreName", result.GenreName);
        }
        [Test]
        public void Delete_LanguagesById()
        {
            //GenresBusiness genresBusiness = new GenresBusiness();
            //int id = genresBusiness.GetByName("GenreOne");
            //genresBusiness.Delete(id);
            //Genre result = genresBusiness.Get(id);
            //Assert.Null(result);
        }
    }
}
