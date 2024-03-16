using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookAuthors
{
    public class Test
    {
        public Test()
        {
            bookAuthorsBusiness = new BookAuthorsBusiness();
            Input();
        }
        private int closeOperationId = 6;
        private BookAuthorsBusiness bookAuthorsBusiness;
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
        private void Add()
        {
            BookAuthor bookAuthor = new BookAuthor();
            Console.WriteLine("Enter Author ID: ");
            bookAuthor.AuthorId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book ID: ");
            bookAuthor.BookId = int.Parse(Console.ReadLine());
            bookAuthorsBusiness.AddBooksAuthors(bookAuthor);
        }
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "AUTHORS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var aurthors = bookAuthorsBusiness.GetAllBooksAuthors();
            foreach (var item in aurthors)
            {
                Console.WriteLine($"{item.AuthorId} {item.BookId} ");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            BookAuthor bookAuthor = bookAuthorsBusiness.GetBooksAuthors(id);
            if (bookAuthor != null)
            {
                Console.WriteLine("Enter Author ID: ");
                bookAuthor.AuthorId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Book ID: ");
                bookAuthor.BookId = int.Parse(Console.ReadLine());
                bookAuthorsBusiness.UpdateBooksAuthors(bookAuthor);
            }
            else
            {
                Console.WriteLine("Author not found!");
            }
        }
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            BookAuthor bookAuthor = bookAuthorsBusiness.GetBooksAuthors(id);
            if (bookAuthor != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID author: " + bookAuthor.AuthorId);
                Console.WriteLine("ID book: " + bookAuthor.BookId);
                Console.WriteLine(new string('-', 40));
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            bookAuthorsBusiness.DeleteBooksAuthors(id);
            Console.WriteLine("Done.");
        }
    }
}
