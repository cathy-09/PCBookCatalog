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
    public class TestNationality
    {
        private BusinessNationalities businessNationalities;
        [SetUp]
        public void Setup()
        {
            businessNationalities = new BusinessNationalities();
        }
        [Test]
        public void GetAll_AllNationalities()
        {
            BusinessNationalities businessNationalities = new BusinessNationalities();
            List<Nationality> result = businessNationalities.GetAllNationalities();
            Assert.AreEqual(result.Count, result.Count);
        }
        [Test]
        public void Get_NationalitiesById()
        {
            BusinessNationalities businessNationalities = new BusinessNationalities();
            int id = 2;
            Nationality result = businessNationalities.GetNationaly(id);
            Assert.NotNull(result);
            Assert.AreEqual(id, result.NationalityId);
        }
        [Test]
        public void Add_NewNationalities()
        {
            BusinessNationalities businessNationalities = new BusinessNationalities();
            Nationality newNationalityOne = new Nationality("NationalityOne");
            Nationality newNationalityTwo = new Nationality("NationalityTwo");
            businessNationalities.AddNationality(newNationalityOne);
            businessNationalities.AddNationality(newNationalityTwo);
            int id = businessNationalities.GetByName(newNationalityOne.Name);
            Nationality result = businessNationalities.GetNationaly(id);
            Assert.AreEqual("NationalityOne", result.Name);
        }
        [Test]
        public void Update_UpdatesExistingNationalities()
        {
            BusinessNationalities businessNationalities = new BusinessNationalities();
            int id = businessNationalities.GetByName("NationalityTwo");
            Nationality nationalityToUpdate = businessNationalities.GetNationaly(id);
            nationalityToUpdate.Name = "Updated NationalityName";
            businessNationalities.UpdateNationality(nationalityToUpdate);
            Nationality result = businessNationalities.GetNationaly(id);
            Assert.AreEqual("Updated NationalityName", result.Name);
        }
        [Test]
        public void Delete_NationalitiesById()
        {
            BusinessNationalities businessNationalities = new BusinessNationalities();
            int id = businessNationalities.GetByName("NationalityOne");
            businessNationalities.DeleteNationality(id);
            Nationality result = businessNationalities.GetNationaly(id);
            Assert.Null(result);
        }
    }
}
