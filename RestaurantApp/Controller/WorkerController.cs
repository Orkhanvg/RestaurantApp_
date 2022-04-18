using Business.Service;
using Entities.Models;
using System;
using Utilities.Helper;

namespace RestaurantApp.Controller
{
    class WorkerController
    {
        private WorkerService WorkerService;
        public WorkerController()
        {
            WorkerService = new WorkerService();
        }
        public void CreateWorker()
        {

            Extention.ShowMe(ConsoleColor.Green, $"Worker Name");
            string name = Console.ReadLine();

            Extention.ShowMe(ConsoleColor.Green, $"Worker Salary");
            int salary = int.Parse(Console.ReadLine());

            Extention.ShowMe(ConsoleColor.Green, $"Worker Count");

            int count = int.Parse(Console.ReadLine());

            Worker worker = new Worker
            {
                Name = name,
                Salary = salary,
                Count = count,

            };

            WorkerService.Create(worker);
            Console.WriteLine("method is break");


        }
        public void GetAllWorker()
        {



            foreach (var item in WorkerService.GetAll())
            {
                Extention.ShowMe(ConsoleColor.Yellow, $"ID: {item.Id}-----NAME: {item.Name}");
            }
        }
        public void RemoveWorker()
        {
            int id = int.Parse(Console.ReadLine());
            Extention.ShowMe(ConsoleColor.Green, $"{WorkerService.Delete(id).Name}");

        }
    }
}
