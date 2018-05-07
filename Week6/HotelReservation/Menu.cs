using HotelReservation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservation
{
    public class Menu
    {
        public bool programRunning = true;

        private IRepositoryPattern<Customer> customerRepository;

        private IRepositoryPattern<Reservation> reservationRepository;

        public Menu()
        {
            IDataSource myDataSource = new MyDataSource();
            IDataSource fileDataSource = new FileDataSource();
            IDataSource dbDataSource = new DBDataSource();

            //customerRepository = new CustomerRepository(fileDataSource);
            //reservationRepository = new ReservationRepository(myDataSource);
            customerRepository = new CustomerRepository(dbDataSource);
            reservationRepository = new ReservationRepository(dbDataSource);
        }

        public void DisplayMenu()
        {
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Options: \n 1. Display all customers " +
                                  "\n 2. Display reservations" +
                                  "\n 3. Add Customer" +
                                  "\n 4. Add reservation for customer" +
                                  "\n 5. Remove Customer" +
                                  "\n 6. Remove Reservation" +
                                  "\n 7. Exit");
                int enteredMenuItem;
                if (int.TryParse(Console.ReadLine(), out enteredMenuItem))
                {
                    switch (enteredMenuItem)
                    {

                        case 1:
                            DisplayAllCustomers();
                            break;
                        case 2:
                            DisplayReservation();
                            break;
                        case 3:
                            AddCustomer();
                            break;
                        case 4:
                            AddReservation();
                            break;
                        case 5:
                            RemoveCustomer();
                            break;
                        case 6:
                            RemoveReservation();
                            break;
                        case 7:
                            programRunning = false;
                            break;
                    }
                }
            } while (programRunning);
        }

        private void DisplayAllCustomers()
        {
            IEnumerable<Customer> customers = customerRepository.GetAll();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        private void DisplayReservation()
        {
            Console.WriteLine("Enter Customer Id");
            int customerId;
            if (int.TryParse(Console.ReadLine(), out customerId))
            {
                IEnumerable<Reservation> reservations = reservationRepository.GetAll().Where(reservation => reservation.CustomerId == customerId);
                if (reservations.Any())
                {
                    foreach (var reservation in reservations)
                    {
                        Console.WriteLine(reservation);
                    }
                }
                else
                {
                    Console.WriteLine("There are no reservation for this customer");
                }
            }
            else
            {
                Console.WriteLine("Invalid customer Id");
            }
        }

        private void AddCustomer()
        {
            throw new NotImplementedException();
        }

        private void AddReservation()
        {
            throw new NotImplementedException();
        }

        private void RemoveCustomer()
        {
            Console.WriteLine("Enter Customer Id");
            int customerId;
            if (int.TryParse(Console.ReadLine(), out customerId))
            {
                var customerToBeRemoved = customerRepository.FindBy(customerToRemove => customerToRemove.Id == customerId).Single();
                customerRepository.Remove(customerToBeRemoved.Id);
            }
            else
            {
                Console.WriteLine("Invalid customer Id");
            }
        }

        private void RemoveReservation()
        {
            throw new NotImplementedException();
        }

        private void SortReservationByCheckInDate()
        {
            throw new NotImplementedException();
        }
    }
}
