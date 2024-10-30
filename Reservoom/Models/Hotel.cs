using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; set; }
        public Hotel(string v)
        {
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetReservations(string user)
        {
            return _reservationBook.GetReservations(user);
        }

        public void AddReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
