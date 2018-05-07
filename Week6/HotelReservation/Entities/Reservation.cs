using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Reservation: IEntity
    {
        public int Id { get; }

        public int CustomerId { get; }

        public string Hotel { get; }

        public DateTime CheckinDate { get; }

        public DateTime CheckoutDate { get; }

        public Reservation(int id, int customerId, string hotel, DateTime checkinDate, DateTime checkoutDate)
        {
            Id = id;
            CustomerId = customerId;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
        }

        public override string ToString()
        {
            return $"Id: {Id}, CustomerId: {CustomerId}, Hotel: {Hotel}, checkin: {CheckinDate.ToShortDateString()}, checkout: {CheckoutDate.ToShortDateString()}";
        }
    }
}
