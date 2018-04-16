using HotelReservation.DataSource;
using HotelReservation.Repository;
using System;
using System.Collections.Generic;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
        }
    }
}
