using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using NUnit.Framework;

namespace NUnitTests
{
    //[Test]
    public class TestAuthor
    {
        private BussinessAuthors bussinessAuthors;
        [SetUp]
        public void Setup()
        {
            bussinessAuthors = new BussinessAuthors();
        }
    }
}
