using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class Reservation
    {
        public RoomID RoomID { get;}
        public string Name { get;}
        public DateTime CheckIn { get; }
        public DateTime CheckOut { get; }
        public TimeSpan Duration => CheckOut - CheckIn;
        public Reservation(RoomID roomID, string name, DateTime checkIn, DateTime checkOut)
        {
            RoomID = roomID;
            Name = name;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.CheckIn < CheckOut || reservation.CheckOut > CheckIn;
        }
    }
}
