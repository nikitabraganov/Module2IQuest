using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            var newRepository = new ReservationRepository();
            Console.WriteLine(newRepository.ReturnAllCustomers());

        }
    }
}
