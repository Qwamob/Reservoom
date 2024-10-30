using Reservoom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservations(string user) 
        {
            return _reservations.Where(r => r.Name == user);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existtingReservation in _reservations)
            {
                if (existtingReservation.Conflicts(reservation)
                {
                    throw new ReservationConflictException(existtingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }
    }
}
