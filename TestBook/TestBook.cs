using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
        private int closeOperationId = 7;
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
            Console.WriteLine("6. sortirai po mehur4eto");
            Console.WriteLine("7. Exit");
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
                    case 6:
                        BubbleSortBookTitle(bookBusiness.GetAll());
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
            book.Author = new Author { Name = Console.ReadLine() };
            Console.WriteLine("Enter author nationality: ");
            book.Author.Nationality = new Nationality { Name = Console.ReadLine() };
            Console.WriteLine("Enter genre: ");
            book.Genre = new Genre { GenreName = Console.ReadLine() };
            Console.WriteLine("Enter publisher: ");
            book.Publisher = new Publisher { PublisherName = Console.ReadLine() };
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
            book.Language = new Language { LanguageName = Console.ReadLine() };
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
                Console.WriteLine($"{item.Id} {item.Name} {item.Author.Name} {item.Genre.GenreName}" +
                    $" {item.Publisher.PublisherName} {item.Rating} {item.Pages} {item.Price} {item.ISBN}" +
                    $" {item.PublicationYear} {item.Language.LanguageName}");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Book book = bookBusiness.Get(id);
            if (book != null)
            {
                //Book book = new Book();
                Console.WriteLine("Enter name: ");
                book.Name = Console.ReadLine();
                Console.WriteLine("Enter author: ");
                book.Author = new Author { Name = Console.ReadLine() };
                Console.WriteLine("Enter author nationality: ");
                book.Author.Nationality = new Nationality { Name = Console.ReadLine() };
                Console.WriteLine("Enter genre: ");
                book.Genre = new Genre { GenreName = Console.ReadLine() };
                Console.WriteLine("Enter publisher: ");
                book.Publisher = new Publisher { PublisherName = Console.ReadLine() };
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
                book.Language = new Language { LanguageName = Console.ReadLine() };
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
                Console.WriteLine("Author: " + book.Author.Name);
                Console.WriteLine("Genre: " + book.Genre.GenreName);
                Console.WriteLine("Publisher: " + book.Publisher.PublisherName);
                Console.WriteLine("Rating: " + book.Rating);
                Console.WriteLine("Pages: " + book.Pages);
                Console.WriteLine("Price: " + book.Price);
                Console.WriteLine("ISBN: " + book.ISBN);
                Console.WriteLine("Publication Year: " + book.PublicationYear);
                Console.WriteLine("Language: " + book.Language.LanguageName);
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

        private void BubbleSortBookTitle(List<Book> books)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < books.Count - 1; i++)
                {
                    if (books[i].Name.CompareTo(books[i + 1].Name) > 0)
                    {
                        Book temp = books[i];
                        books[i] = books[i + 1];
                        books[i + 1] = temp;

                        flag = true;
                    }
                }
            }
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Id} {book.Name} {book.Author.Name} {book.Genre.GenreName}" +
                    $" {book.Publisher.PublisherName} {book.Rating} {book.Pages} {book.Price} {book.ISBN}" +
                    $" {book.PublicationYear} {book.Language.LanguageName}");
            }
        }
    }
}
