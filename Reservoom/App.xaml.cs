using Reservoom.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Imperial Hotel");

            hotel.AddReservation(new Reservation(
                new RoomID(1, 3)),
                "John Doe",
                new DateTime(2021, 1, 1),
                new DateTime(2021, 1, 3));
            base.OnStartup(e);
        }

    }

}
