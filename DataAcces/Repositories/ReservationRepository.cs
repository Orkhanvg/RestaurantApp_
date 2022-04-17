using DataAcces;
using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class ReservationRepository : IRepository<Reservation>
    {

        public bool Create(Reservation entity)
        {
            try
            {
                DataContext.Reservations.Add(entity);
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
                DataContext.Reservations.Remove(entity);
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


                return DataContext.Reservations.FindAll(filter);


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
                return filter == null ? DataContext.Reservations[0] :
                    DataContext.Reservations.Find(filter);

            }
            catch (global::System.Exception)
            {

                throw;
            }
        }



        public bool Update(Reservation entity)
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