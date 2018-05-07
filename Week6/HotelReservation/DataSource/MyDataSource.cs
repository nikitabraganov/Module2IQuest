using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class MyDataSource : IDataSource
    {
        public List<Customer> LoadCustomers()
        {
            return new List<Customer>
            {
                new Customer(1, "Andreea"),
                new Customer(2, "Alin")
            };
        }

        public List<Reservation> LoadReservation()
        {
            return new List<Reservation>
            {
                new Reservation(1,1,"Ramada", DateTime.Now, DateTime.Now.AddDays(5)),
                new Reservation(2,2,"Ramada", DateTime.Now.AddDays(1), DateTime.Now.AddDays(5)),
                new Reservation(3,2,"Golden House", DateTime.Now.AddDays(2), DateTime.Now.AddDays(5)), 
            };
        }
    }
}
