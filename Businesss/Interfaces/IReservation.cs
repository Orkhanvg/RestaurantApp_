using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Interfaces
{
    interface IReservation
    {
        Reservation Create(Reservation reservation);

        Reservation Update(int Id, Reservation reservation);

        Reservation Delete(int id);

        List<Reservation> GetAll();
    }
}
