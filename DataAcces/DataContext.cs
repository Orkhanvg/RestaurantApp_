using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
   public  class DataContext
    {


        public static List<Reservation> Reservations;
        public static List<Worker> Workers;
        public DataContext()
        {
            Reservations = new List<Reservation>();
            Workers = new List<Worker>();
        }
    }
}
