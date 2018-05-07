using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Repository
{
    public class CustomerRepository: Repository<Customer>
    {
        public CustomerRepository(IDataSource dataSource) : base(dataSource)
        {
            Data = dataSource.LoadCustomers();
        }
    }
}
