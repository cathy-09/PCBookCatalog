using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAuthor
{
    [TestClass]
    public class TestAuthor
    {
        private BussinessAuthors bussinessAuthors;
        [SetUp]
        public void Setup()
        {
            bussinessAuthors = new BussinessAuthors();
        }
        [TestMethod]
        public void GetAllReturnsAllAuthors()
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
        [TestMethod]
        public void GetReturnsAuthorWithCorrectId()
        {
            int authorId = 1;
            Author expectedAuthor = new Author { AuthorId = authorId, Name = "Test Author" };
            bussinessAuthors.Add(expectedAuthor);
            Author actualAuthor = bussinessAuthors.Get(authorId);
            Assert.AreEqual(expectedAuthor.AuthorId, actualAuthor.AuthorId);
            Assert.AreEqual(expectedAuthor.Name, actualAuthor.Name);
        }
        [TestMethod]
        public void AddAddsNewAuthorToDatabase()
        {
            Author newAuthor = new Author { Name = "New Author" };
            bussinessAuthors.Add(newAuthor);
            List<Author> authorsAfterAdd = bussinessAuthors.GetAll();
            Assert.IsTrue(authorsAfterAdd.Any(a => a.Name == newAuthor.Name));
        }
        [TestMethod]
        public void UpdateUpdatesAuthorInDatabase()
        {
            Author existingAuthor = new Author { Name = "Existing Author" };
            bussinessAuthors.Add(existingAuthor);
            string updatedName = "Updated Author";
            existingAuthor.Name = updatedName;
            bussinessAuthors.Update(existingAuthor);
            Author updatedAuthor = bussinessAuthors.Get(existingAuthor.AuthorId);
            Assert.AreEqual(updatedName, updatedAuthor.Name);
        }
        [TestMethod]
        public void DeleteRemovesAuthorFromDatabase()
        {
            Author authorToDelete = new Author { Name = "Author to Delete" };
            bussinessAuthors.Add(authorToDelete);
            bussinessAuthors.Delete(authorToDelete.AuthorId);
            List<Author> authorsAfterDelete = bussinessAuthors.GetAll();
            Assert.IsFalse(authorsAfterDelete.Any(a => a.AuthorId == authorToDelete.AuthorId));
        }
    }
}

