using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenres
{
    public class TestGenres
    {
        public TestGenres()
        {
            genresBusiness = new GenresBusiness();
            Input();
        }
        private int closeOperationId = 6;
        private GenresBusiness genresBusiness;
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
            Genre genre = new Genre();
            Console.WriteLine("Enter name: ");
            genre.GenreName = Console.ReadLine();
            genresBusiness.Add(genre);
        }
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "GENRE" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var genres = genresBusiness.GetAll();
            foreach (var item in genres)
            {
                Console.WriteLine($"{item.GenreId} {item.GenreName}");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Genre genre = genresBusiness.Get(id);
            if (genre != null)
            {
                Console.WriteLine("Enter name: ");
                genre.GenreName = Console.ReadLine();
                genresBusiness.Update(genre);
            }
            else
            {
                Console.WriteLine("Genres not found");
            }
        }
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Genre genre = genresBusiness.Get(id);
            if (genre != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + genre.GenreId);
                Console.WriteLine("Name: " + genre.GenreName);
                Console.WriteLine(new string('-', 40));
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            genresBusiness.Delete(id);
            Console.WriteLine("Done.");
        }
    }
}
