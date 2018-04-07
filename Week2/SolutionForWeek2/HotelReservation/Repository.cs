using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Repository<T> : IRepositoryPattern<T> where T : class, IEntity
    {
        List<T> repositoryList;

        public Repository(List<T> repoToAdd)
        {
            repositoryList = repoToAdd;
        }

        public void Add(T entityToAdd)
        {
            repositoryList.Add(entityToAdd);
        }

        public List<T> GetAll()
        {
            return repositoryList;
        }

        public T GetById(int id)
        {
            return repositoryList.Single(itemToFindById => itemToFindById.Id.Equals(id));
        }

        public void Remove(int id)
        {
            repositoryList.Single(itemToRemoveById => itemToRemoveById.Id.Equals(id));
        }
    }
}
