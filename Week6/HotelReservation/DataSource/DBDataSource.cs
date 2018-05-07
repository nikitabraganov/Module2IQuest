using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class DBDataSource : HotelReservationsDB, IDataSource
    {
        public List<Customer> LoadCustomers()
        {
            return CustomerDB.ToList().ConvertAll(newType => new Customer(newType.ID, newType.FirstName + " " + newType.LastName));
        }

        public List<Reservation> LoadReservation()
        {
            return ReservationDB.ToList().ConvertAll(newType => new Reservation(newType.ID, newType.CustomerId.Value, "Default", newType.CheckInDate.Value, newType.CheckOutDate.Value));
        }
    }
}
