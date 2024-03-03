using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookAuthorsBusiness
    {
        private BookCatalogContext bookCatalogContext;
        
        //public List<Authors> GetAllBookAuthors() 
        //{
        //    using (bookCatalogContext = new BookCatalogContext())
        //    {
        //        //return bookCatalogContext.BooksAuthors.Include(e => e.Authors).ToList();
        //        return ;

        //    }
        //}
        //public BooksAuthors Get(int id)
        //{
        //    using (bookCatalogContext = new BookCatalogContext())
        //    {
        //        return bookCatalogContext.BooksAuthors.Find(id);
        //    }
        //}
    }
}
