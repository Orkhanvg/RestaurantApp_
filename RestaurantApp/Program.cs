using Business.Service;

using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace RestaurantApp
{
    class Program
    { 
        static void Main(string[] args)
        {
      open:      Extention.ShowMe(ConsoleColor.Green, "1-Reservation\n" +
         "2-Workers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    WorkerService workerService = new WorkerService();
                    Extention.ShowMe(ConsoleColor.White, "Welcome to Heaven");
                    while (true)
                    {
                        Extention.ShowMe(ConsoleColor.DarkCyan, "1-Create Worker\n" +
                            "2-Update Worker\n" +
                            "3-Remove Worker\n+" +
                            "4-Get Worker");
                        string num = Console.ReadLine();
                        int input;

                        bool IsNum = int.TryParse(num, out input);
                        if (IsNum && input < 100 && input > 0)
                        {
                            switch (input)
                            {
                                case 1:
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the name");
                                    string name = Console.ReadLine();
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the salary");
                                    double salary = Convert.ToDouble(Console.ReadLine());
                                    Worker worker = new Worker
                                    {
                                        Name = name,
                                        Salary = salary
                                    };
                                    workerService.Create(worker);
                                    break;

                                case 2:
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the ID");
                                    int ID = Convert.ToInt16(Console.ReadLine());
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the new name");
                                    string name1 = Console.ReadLine();
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the recent salary");
                                    double salary1 = Convert.ToDouble(Console.ReadLine());
                                    Worker worker1 = new Worker
                                    {
                                        Name = name1,
                                        Salary = salary1
                                    };
                                    workerService.Update(ID, worker1);
                                    break;

                                case 3:
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the ID");
                                    int ID1 = Convert.ToInt16(Console.ReadLine());
                                    workerService.Delete(ID1);
                                    break;
                                case 4:
                                    List<Worker> list = workerService.GetAll();
                                    foreach (var item in list)
                                    {
                                        Console.WriteLine(item.Name);
                                    }
                                    break;





                            }
                        }
                    }
                case 2:
                default:
                    ReservationService reservationService = new ReservationService();
                    Extention.ShowMe(ConsoleColor.White, "Welcome to Heaven");
                    while (true)
                    {
                        Extention.ShowMe(ConsoleColor.DarkCyan, "1-Create  Reservation\n" +
                            "2-Update Reservation\n" +
                            "3-Remove Reservation\n+" +
                            "4-Get Reservation");
                        string num1 = Console.ReadLine();
                        int input1;

                        bool IsNum1 = int.TryParse(num1, out input1);
                        if (IsNum1 && input1 < 100 && input1 > 0)
                        {
                            switch (input1)
                            {
                                case 1:
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the name");
                                    string name = Console.ReadLine();
                                    Extention.ShowMe(ConsoleColor.DarkCyan, "Please enter the count");
                                    int salary = Convert.ToInt16(Console.ReadLine());
                                    break;

                                case 2:
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the ID");
                                    int ID = Convert.ToInt16(Console.ReadLine());
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the new name");
                                    string name1 = Console.ReadLine();
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the recent salary");
                                    double salary1 = Convert.ToDouble(Console.ReadLine());
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the total cost");
                                    double TotalCost = Convert.ToDouble(Console.ReadLine());
                                    break;

                                case 3:
                                    Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the ID");
                                    int ID1 = Convert.ToInt16(Console.ReadLine());
                                    break;
                                case 4:
                                    List<Reservation> list = reservationService.GetAll();
                                    foreach (var item in list)
                                    {
                                        Console.WriteLine(item.Name);
                                    }
                                    break;
                                    goto open;
                    break;
            }

            





                    }
                }
            }

        }
    }
}
