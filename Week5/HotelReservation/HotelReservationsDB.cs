namespace HotelReservation
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelReservationsDB : DbContext
    {
        public HotelReservationsDB()
            : base("name=HotelReservationsDB")
        {
        }

        public virtual DbSet<CustomerDB> CustomerDB { get; set; }
        public virtual DbSet<ReservationDB> ReservationDB { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDB>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerDB>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerDB>()
                .HasMany(e => e.ReservationDB)
                .WithOptional(e => e.CustomerDB)
                .HasForeignKey(e => e.CustomerId);
        }
    }
}
