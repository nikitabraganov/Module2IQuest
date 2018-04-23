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
            return Data.FirstOrDefault(itemToFindById => itemToFindById.Id.Equals(id));
        }

        public void Remove(int id)
        {
            Data.Remove(Data.FirstOrDefault(itemToRemoveById => itemToRemoveById.Id.Equals(id)));
        }

        public IEnumerable<T> FindBy(Func<T, bool> predicate)
        {
            return Data.Where(predicate);
        }
    }
}
