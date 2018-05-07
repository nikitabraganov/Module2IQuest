using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public interface IDataSource
    {
        List<Customer> LoadCustomers();

        List<Reservation> LoadReservation();
    }
}
