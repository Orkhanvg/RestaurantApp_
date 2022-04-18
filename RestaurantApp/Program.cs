using Business.Service;

using Entities.Models;
using RestaurantApp.Controller;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerController workerController = new WorkerController();
            Extention.ShowMe(ConsoleColor.Green, "1-Reservation\n" +
            "2-Workers\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ReservationService reservationService = new ReservationService();
                    ReservationController reservationController = new ReservationController();
                    Extention.ShowMe(ConsoleColor.White, "Welcome to Heaven\n");
                    while (true)
                    {
                        Extention.ShowMe(ConsoleColor.DarkCyan, "1-Create  Reservation\n" +
                            "2-Update Reservation\n" +
                            "3-Remove Reservation\n+" +
                            "4-Get Reservation\n");
                        string num1 = Console.ReadLine();
                        int input1;

                        bool IsNum1 = int.TryParse(num1, out input1);
                        if (IsNum1 && input1 < 4 && input1 > 0)
                        {
                            switch (input1)
                            {
                                case 1:
                                    Console.Clear();
                                    reservationController.CreateReservation();

                                    //Extention.ShowMe(ConsoleColor.DarkCyan, "Please enter Date");
                                    //DateTime date =Convert.ToDateTime(Console.ReadLine());
                                    break;


                                case 2:
                                    Console.Clear();
                                    reservationController.GetAllReservation();
                                    break;

                                case 3:
                                    Console.Clear();
                                    reservationController.RemoveReservation();
                                    break;

                                case 4:
                                    List<Reservation> list = reservationService.GetAll();
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
                        if (IsNum && input < 4 && input > 0)
                        {
                            switch (input)
                            {
                                case 1:
                                    Console.Clear();
                                    workerController.CreateWorker();
                                    break;

                                case 2:
                                    Console.Clear();
                                    workerController.GetAllWorker();
                                    break;

                                case 3:
                                    Console.Clear();
                                    workerController.RemoveWorker();
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

                
                  }

        }
    }
}
