using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLanguage
{
    public class TestLanguage
    {
        public TestLanguage()
        {
            languagesBusiness = new LanguagesBusiness();
            Input();
        }
        private int closeOperationId = 6;
        private LanguagesBusiness languagesBusiness;
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
            Language language = new Language();
            Console.WriteLine("Enter name: ");
            language.LanguageName = Console.ReadLine();
            Console.WriteLine("Enter code: ");
            language.LanguageCode = int.Parse(Console.ReadLine());
            languagesBusiness.Add(language);
        }
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "LANGUAGE" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var languages = languagesBusiness.GetAll();
            foreach (var item in languages)
            {
                Console.WriteLine($"{item.LanguageId} {item.LanguageName} {item.LanguageCode}");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Language language = languagesBusiness.Get(id);
            if (language != null)
            {
                Console.WriteLine("Enter name: ");
                language.LanguageName = Console.ReadLine();
                Console.WriteLine("Enter code: ");
                language.LanguageCode = int.Parse(Console.ReadLine());
                languagesBusiness.Update(language);
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Language language = languagesBusiness.Get(id);
            if (language != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + language.LanguageId);
                Console.WriteLine("Name: " + language.LanguageId);
                Console.WriteLine("Code: " + language.LanguageCode);
                Console.WriteLine(new string('-', 40));
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            languagesBusiness.Delete(id);
            Console.WriteLine("Done.");
        }
    }
}

