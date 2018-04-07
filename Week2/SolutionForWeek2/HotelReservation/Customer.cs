using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Customer : IEntity
    {
        public int Id { get; }
        public string UserName;
        public string Password;
        public string Adress;

        public Customer(int id, string username, string password, string adress)
        {
            Id = id;
            UserName = username;
            Password = password;
            Adress = adress;
        }
    }
}
