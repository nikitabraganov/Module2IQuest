using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public interface IRepositoryPattern<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T customerToAdd);
        void Remove(int id);
    }
}
