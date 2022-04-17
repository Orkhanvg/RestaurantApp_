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


        public static List<Reservation> Reservations { get; set; }
        public static List<Worker> Workers { get; set; }
        public DataContext()
        {
            Reservations = new List<Reservation>();
            Workers = new List<Worker>();
        }
    }
}
