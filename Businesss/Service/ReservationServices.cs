using Business.Interfaces;
using Businesss.Interfaces;
using DataAcces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Service
{
    

        public class ReservationService : IReservation
        {
            public static int Count { get; set; }

            private ReservationRepository _ReservationRepository;
            public ReservationService()
            {
                _ReservationRepository = new ReservationRepository();
            }



            public Reservation Create(Reservation Reservation)
            {
                Reservation.Id = Count;

                _ReservationRepository.Create(Reservation);
                Count++;
                return Reservation;
            }
            public Reservation Delete(int Id)
            {
                Reservation Reservation = DataContext.Reservations.Find(x => x.Id == Id);
                _ReservationRepository.Delete(Reservation);
                return Reservation;
            }



            public Reservation Update(int id, Reservation Reservation)
            {
                Reservation Reservation1 = DataContext.Reservations.Find(x => x.Id == id);
                Reservation.Name = Reservation.Name;

                _ReservationRepository.Update(Reservation1);
                return Reservation;
            }



            public List<Reservation> GetAll()
            {

                return _ReservationRepository.GetAll(x => x.Id == x.Id);

            }
        }
    }
