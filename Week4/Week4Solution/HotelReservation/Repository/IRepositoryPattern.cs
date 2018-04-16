using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public interface IRepositoryPattern<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T customerToAdd);
        void Remove(int id);
        IEnumerable<T> SearchFor(Func<T, bool> predicate);
    }
}
