using System;[]
using System.Collections.Generic;
using System.Text;

namespace Business.Repositories
{
   public class ReservationRepository:IRepository<Reservation>
    {
        public bool Create (Reservation entity)
        {
            try
            {
                DataContext.Reservation.Add(entity);
                return true;
            }
            catch (global::System.Exception)
            {

                throw;
            }


        }
        public bool Delete(Reservation entity)
        {
            try
            {
                DataContext.Reservation.Remove(entity);
                return true;
            }
            catch (global::System.Exception)
            {

                throw;
            }
        }
         public List<Reservation> GetAll(Predicate<Reservation> filter = null)
        {
            try
            {
                return DataContext.Reservation.FindAll(filter);

            }
            catch (global::System.Exception)
            {

                throw;
            }
        }

        public Reservation GetOne(Predicate<Reservation> filter = null)
        {
            try
            {
                return DataContext.Reservation.Find(filter);
            }
            catch (global::System.Exception)
            {

                throw;
            }
        }
        public bool Update (Reservation entity)
        {
            try
            {
                Reservation isExist = GetOne(r => r.Name == entity.Name);
                isExist = entity;
                return true;
            }
            catch (global::System.Exception)
            {

                throw;
            }
        }
    }
}
