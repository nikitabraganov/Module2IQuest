using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Repository
{
    public class ReservationRepository : Repository<Reservation>
    {
        public ReservationRepository(IDataSource dataSource) : base(dataSource)
        {
            Data = dataSource.LoadReservation();
        }
    }
}
