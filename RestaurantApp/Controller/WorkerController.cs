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
        EnterName:
            Extention.ShowMe(ConsoleColor.Green, $"Worker Name");
            string name = Console.ReadLine();

            Extention.ShowMe(ConsoleColor.Green, $"Worker Salary");
            string inputsalary = Console.ReadLine();
            int salary;


            bool isSize = int.TryParse(inputsalary, out salary);
            if (isSize)
            {
                Worker worker = new Worker()
                {
                    Name = name,
                    Salary=salary,
                    
                };

                WorkerService.Create(worker);
                Extention.ShowMe(ConsoleColor.Green, $"{worker.Name} created");
            }
            else
            {
                Extention.ShowMe(ConsoleColor.Red, "Enter the correct option");
                goto EnterName;
            }
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
