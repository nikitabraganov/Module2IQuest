using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public interface IRepositoryPattern<T> where T : class
    {
        List<T> ReturnAllCustomers();
        void Add(T customerToAdd);
    }
}
