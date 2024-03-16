using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAuthors
{
    public class AuthorTest
    {
        public AuthorTest()
        {
            bussinessAuthors = new BussinessAuthors();
            Input();
        }
        private int closeOperationId = 6;
        private BussinessAuthors bussinessAuthors;
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
            Author author = new Author();
            Console.WriteLine("Enter Author name: ");
            author.Name = Console.ReadLine();
            Console.WriteLine("Enter nationality Id: ");
            author.NationalityId = int.Parse(Console.ReadLine());
            bussinessAuthors.Add(author);
        }
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "AUTHORS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var aurthors = bussinessAuthors.GetAll();
            foreach (var item in aurthors)
            {
                Console.WriteLine($"{item.AuthorId} {item.Name} {item.NationalityId}");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Author author = bussinessAuthors.Get(id);
            if (author != null)
            {
                Console.WriteLine("Enter name: ");
                author.Name = Console.ReadLine();
                Console.WriteLine("Enter nationalityId: ");
                author.NationalityId = int.Parse(Console.ReadLine());
                bussinessAuthors.Update(author);
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
            Author author = bussinessAuthors.Get(id);
            if (author != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + author.AuthorId);
                Console.WriteLine("Name: " + author.Name);
                Console.WriteLine("Nationality: " + author.NationalityId);
                Console.WriteLine(new string('-', 40));
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            bussinessAuthors.Delete(id);
            Console.WriteLine("Done.");
        }
    }
}
