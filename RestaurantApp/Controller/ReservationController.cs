using Business.Service;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace RestaurantApp.Controller
{
    class ReservationController
    {

        private ReservationService ReservationService;
        public ReservationController()
        {
            ReservationService = new ReservationService();
        }
        public void CreateReservation()
        {
        EnterName:
            Extention.ShowMe(ConsoleColor.Green, $"Reservation Name");
            string name = Console.ReadLine();

            Extention.ShowMe(ConsoleColor.Green, $"Reservation TotalCost");
            string inputTotalCost = Console.ReadLine();
            double Totalcost;


            bool isSize = double.TryParse(inputTotalCost, out Totalcost);
            if (isSize)
            {
                Reservation Reservation = new Reservation()
                {
                    Name = name,
                    TotalCost = Totalcost,
                    CreateTime = Convert.ToDateTime(Console.ReadLine()),

                };

                ReservationService.Create(Reservation);
                Extention.ShowMe(ConsoleColor.Green, $"{Reservation.Name} created");
            }
            else
            {
                Extention.ShowMe(ConsoleColor.Red, "Enter the correct option");
                goto EnterName;
            }
        }
        public void GetAllReservation()
        {



            foreach (var item in ReservationService.GetAll())
            {
                Extention.ShowMe(ConsoleColor.Yellow, $"ID: {item.Id}-----NAME: {item.Name}----SALARY: {item.Salary}");
            }
        }
        public void RemoveReservation()
        {
            int id = int.Parse(Console.ReadLine());
            Extention.ShowMe(ConsoleColor.Green, $"{ReservationService.Delete(id).Name}");

        }
    }
}
