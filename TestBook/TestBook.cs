using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Data.Models;

namespace TestBook
{
    public class TestBook
    {
        public TestBook()
        {
            bookBusiness = new BookBusiness();
            Input();
        }
        private int closeOperationId = 6;
        private BookBusiness bookBusiness;
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
            Book book = new Book();
            Console.WriteLine("Enter name: ");
            book.Name = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            book.Author.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter genre: ");
            book.Genre.GenreId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter publisher: ");
            book.Publisher.PublisherId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rating: ");
            book.Rating = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter pages: ");
            book.Pages = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            book.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter ISBN: ");
            book.ISBN = Console.ReadLine();
            Console.WriteLine("Enter publication year: ");
            book.PublicationYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter language: ");
            book.Language.LanguageId = int.Parse(Console.ReadLine());
            bookBusiness.Add(book);
        }
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "BOOK" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var books = bookBusiness.GetAll();
            foreach (var item in books)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Author.Id} {item.Genre.GenreId}" +
                    $" {item.Publisher.PublisherId} {item.Rating} {item.Pages} {item.Price} {item.ISBN}" +
                    $" {item.PublicationYear} {item.Language.LanguageId}");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Book book = bookBusiness.Get(id);
            if (book != null)
            {
                Console.WriteLine("Enter name: ");
                book.Name = Console.ReadLine();
                Console.WriteLine("Enter author: ");
                book.Author.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter genre: ");
                book.Genre.GenreId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter publisher: ");
                book.Publisher.PublisherId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter rating: ");
                book.Rating = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter pages: ");
                book.Pages = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter price: ");
                book.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter ISBN: ");
                book.ISBN = Console.ReadLine();
                Console.WriteLine("Enter publication year: ");
                book.PublicationYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter language: ");
                book.Language.LanguageId = int.Parse(Console.ReadLine());
                bookBusiness.Update(book);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Book book = bookBusiness.Get(id);
            if (book != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + book.Id);
                Console.WriteLine("Name: " + book.Name);
                Console.WriteLine("Author: " + book.Author.Id);
                Console.WriteLine("Genre: " + book.Genre.GenreId);
                Console.WriteLine("Publisher: " + book.Publisher.PublisherId);
                Console.WriteLine("Rating: " + book.Rating);
                Console.WriteLine("Pages: " + book.Pages);
                Console.WriteLine("Price: " + book.Price);
                Console.WriteLine("ISBN: " + book.ISBN);
                Console.WriteLine("Publication Year: " + book.PublicationYear);
                Console.WriteLine("Language: " + book.Language.LanguageId);
                Console.WriteLine(new string('-', 40));
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            bookBusiness.Delete(id);
            Console.WriteLine("Done.");
        }
    }
}
