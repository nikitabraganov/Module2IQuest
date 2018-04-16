using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Repository<T> : IRepositoryPattern<T> where T : IEntity
    {
        protected List<T> Data;

        public Repository(IDataSource dataSource)
        {

        }

        public void Add(T entityToAdd)
        {
            Data.Add(entityToAdd);
        }

        public List<T> GetAll()
        {
            return Data;
        }

        public T GetById(int id)
        {
            return Data.Single(itemToFindById => itemToFindById.Id.Equals(id));
        }

        public void Remove(int id)
        {
            Data.Remove(Data.Single(itemToRemoveById => itemToRemoveById.Id.Equals(id)));
        }

        public IEnumerable<T> SearchFor(Func<T, bool> predicate)
        {
            return Data.Where(predicate);
        }
    }
}
