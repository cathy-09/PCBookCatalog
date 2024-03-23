using System;
using UnitTestProject1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Models;
using Data;
using Microsoft.EntityFrameworkCore;

namespace UnitTestProject1
{
    public class AuthorTest
    {
        [TestMethod]
        public void GetAll_ReturnsAllAuthors()
        {
            List<Author> expectedAuthors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "Author 1" },
                 new Author { AuthorId = 2, Name = "Author 2" },
                 new Author { AuthorId = 3, Name = "Author 3" }
            };
            List<Author> actualAuthors = bussinessAuthors.GetAll();
            Assert.AreEqual(expectedAuthors.Count, actualAuthors.Count);
            for (int i = 0; i < expectedAuthors.Count; i++)
            {
                Assert.AreEqual(expectedAuthors[i].AuthorId, actualAuthors[i].AuthorId);
                Assert.AreEqual(expectedAuthors[i].Name, actualAuthors[i].Name);
            }
        }
    }
}
