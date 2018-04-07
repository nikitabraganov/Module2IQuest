using System;
using System.Collections.Generic;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Reservation> reservationList = new List<Reservation>();
            List<Customer> customerList = new List<Customer>();
            using (System.IO.StreamReader file = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + "\\Customers.txt"))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    customerList.Add(new Customer(int.Parse(words[0]), words[1], words[2], words[3]));
                }
            }
            foreach (Customer displayCustomer in customerList)
            {
                Console.WriteLine(displayCustomer.Id);
                Console.WriteLine(displayCustomer.UserName);
                Console.WriteLine(displayCustomer.Adress);
                Console.WriteLine();
            }
            Console.WriteLine();

            reservationList.Add(new Reservation(customerList[0], "Causeni", "Varga", "21.01.2018", "21.02.2018"));
            reservationList.Add(new Reservation(customerList[0], "Vaslui", "NewHotel", "21.01.2018", "21.02.2018"));
            reservationList.Add(new Reservation(customerList[0], "Stegareni", "OldHotel", "21.01.2018", "21.02.2018"));

            var reservationRepository = new Repository<Reservation>(reservationList);
            var customerRepository = new Repository<Customer>(customerList);

            Console.WriteLine("Enter the customer id to see reservations");
            var idToSearch = int.Parse(Console.ReadLine());

            Customer searchedCustomer = customerRepository.GetById(idToSearch);

            IEnumerable<Reservation> reservedHotels = reservationRepository.GetAll().FindAll(input => input.customer.Id == searchedCustomer.Id);

            Console.WriteLine("The customer {0} has reservation in: ", searchedCustomer.UserName);

            foreach (Reservation reservation in reservedHotels)
            {
                Console.WriteLine("Hotel location: {0}", reservation.HotelCityLocation);
                Console.WriteLine("Hotel name: {0}", reservation.HotelName);
                Console.WriteLine("CheckIn Date of customer: {0}", reservation.CheckInDate);
                Console.WriteLine("Checkout Date of customer: {0}", reservation.CheckOutDate);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
