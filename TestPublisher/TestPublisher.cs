﻿using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPublisher
{
    public class TestPublisher
    {
        public TestPublisher()
        {
            publishersBusiness = new PublishersBusiness();
            Input();
        }
        private int closeOperationId = 6;
        private PublishersBusiness publishersBusiness;
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
            Publisher publisher = new Publisher();
            Console.WriteLine("Enter Publisher name: ");
            publisher.PublisherName = Console.ReadLine();
            publishersBusiness.AddPublishers(publisher);
        }
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PUBLISHERS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var publisher = publishersBusiness.GetAllPublishers();
            foreach (var item in publisher)
            {
                Console.WriteLine($"{item.PublisherId} {item.PublisherName}");
            }
        }
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Publisher publisher = publishersBusiness.GetPublishers(id);
            if (publisher != null)
            {
                Console.WriteLine("Enter Publisher name: ");
                publisher.PublisherName = Console.ReadLine();
                publishersBusiness.UpdatePublishers(publisher);
            }
            else
            {
                Console.WriteLine("Publisher not found");
            }
        }
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Publisher publisher = publishersBusiness.GetPublishers(id);
            if (publisher != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + publisher.PublisherId);
                Console.WriteLine("Name: " + publisher.PublisherName);
                Console.WriteLine(new string('-', 40));
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            publishersBusiness.DeletePublishers(id);
            Console.WriteLine("Done.");
        }
    }
}
