using Microsoft.EntityFrameworkCore;
using movie_reservation_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_reservation_app
{
    public class MovieReservationDbContext : DbContext
    {
        public MovieReservationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MovieRecord> Movies { get; set; }

        public DbSet<ReservationRecord> Reservations { get; set; }

        public DbSet<GenreTypeRecord> GenreType { get; set; }
    }
}
