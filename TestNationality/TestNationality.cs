using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Data.Models;

namespace TestNationality
{
    public class TestNationality
    {
        public TestNationality()
        {
            businessNationalities = new BusinessNationalities();
            Input();
        }
        private int closeOperationId = 6;
        private BusinessNationalities businessNationalities;
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
            Nationality nationality = new Nationality();
            Console.WriteLine("Enter name: ");
            nationality.Name = Console.ReadLine();
            businessNationalities.AddNationality(nationality);
        }
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "NATIONALITY" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var nationality = businessNationalities.GetAllNationalities();
            foreach (var item in nationality)
            {
                Console.WriteLine($"{item.NationalityId} {item.Name}");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Nationality nationality = businessNationalities.GetNationaly(id);
            if (nationality != null)
            {
                Console.WriteLine("Enter name: ");
                nationality.Name = Console.ReadLine();
                businessNationalities.UpdateNationality(nationality);
            }
            else
            {
                Console.WriteLine("Nationality not found");
            }
        }
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Nationality nationality = businessNationalities.GetNationaly(id);
            if (nationality != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + nationality.NationalityId);
                Console.WriteLine("Name: " + nationality.Name);
                Console.WriteLine(new string('-', 40));
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            businessNationalities.DeleteNationality(id);
            Console.WriteLine("Done.");
        }
    }
}

