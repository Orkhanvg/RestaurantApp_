using Business.Services;
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
                            break;

                        case 2:
                            Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the ID");
                            int ID = Convert.ToInt16(Console.ReadLine());
                            Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the new name");
                            string name1 = Console.ReadLine();
                            Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the recent salary");
                            double salary1 = Convert.ToDouble(Console.ReadLine());
                            break;
                           
                        case 3:
                            Extention.ShowMe(ConsoleColor.DarkYellow, "Please enter the ID");
                            int ID1 = Convert.ToInt16(Console.ReadLine());
                            break;
                        case 4:
                            List<Worker> list = workerService.GetAll();
                            foreach (var item in collection)
                            {
                                Console.WriteLine(item.Name);
                            }
                            break;



                  

                    }
                }
                ReservationService reservationService = new reservationService();
                Extention.ShowMe(ConsoleColor.White, "Welcome to Heaven");
                while (true)
                {
                    Extention.ShowMe(ConsoleColor.DarkCyan, "1-Create  Reservation\n" +
                        "2-Update Reservation\n" +
                        "3-Remove Reservation\n+" +
                        "4-Get Reservation");
                    string num1 = Console.ReadLine();
                    int input1;

                    bool IsNum1 = int.TryParse(num, out input);
                    if (IsNum && input < 100 && input > 0)
                    {
                        switch (input)
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
                                List<Worker> list = reservationService.GetAll();
                                foreach (var item in collection)
                                {
                                    Console.WriteLine(item.Name);
                                }
                                break;





                        }
                    }
                }
            }
        }
    }
}
