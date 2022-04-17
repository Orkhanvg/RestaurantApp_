using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Service
{
    public class ReservationServices
    {

        public static int Count { get; set; }

        private ReservationRepository reservationRepository;
        public ReservationService()
        {
            reservationRepository = new ReservationRepository();
        }
        public ReservationService()
        {

        }


        public Reservation Create(Reservation reservation)
        {
            reservation.Id = Count;

            _reservationRepository.Create(reservation);
            Count++;
            return reservation;
        }
        public ReservationService Delete(int Id)
        {

        }

        public global::System.Collections.Generic.List<global::Entities.Models.Reservation> GetAll()
        {
            throw new global::System.NotImp
    }
}
