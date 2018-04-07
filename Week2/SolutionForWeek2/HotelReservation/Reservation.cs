using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Reservation: IEntity
    {
        public Customer customer;
        public int Id { get; }

        public string HotelCityLocation;
        public string HotelName;
        public string CheckInDate;
        public string CheckOutDate;



        public Reservation(Customer c, string hotelCityLocation, string hotelName, string checkinDate, string checkOutDate)
        {
            customer = c;
            HotelCityLocation = hotelCityLocation;
            HotelName = hotelName;
            CheckInDate = checkinDate;
            CheckOutDate = checkOutDate;
        }
    }
}
