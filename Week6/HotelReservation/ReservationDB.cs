namespace HotelReservation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationDB")]
    public partial class ReservationDB
    {
        public int ID { get; set; }

        public int? CustomerId { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public virtual CustomerDB CustomerDB { get; set; }
    }
}
