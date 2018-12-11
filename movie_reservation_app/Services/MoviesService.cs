using movie_reservation_app.Dtos;
using movie_reservation_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_reservation_app.Service
{
    public class MoviesService : IMoviesService
    {
        private readonly MovieReservationDbContext _context;

        public MoviesService(MovieReservationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MovieDto>> GetAllMovies()
        {
            var movieRecords = _context.Movies.ToList();
            return movieRecords.Select( x => new MovieDto
            {
                Title = x.Title,
                Description = x.Description,
                PlacesAvailable = x.PlacesAvailable,
                PlacesReserved = x.PlacesReserved,
                Genre = _context.Find<GenreTypeRecord>(x.GenreTypeId).Name,
                GenreTypeId = x.GenreTypeId
            });
        }

        public async Task<MovieDto> GetMovieById(int id)
        {
            var movieRecord = await _context.FindAsync<MovieRecord>(id);
            if (movieRecord == null)
            {
                throw new NotImplementedException();
            }
            return new MovieDto
            {
                Title = movieRecord.Title,
                Description = movieRecord.Description,
                PlacesAvailable = movieRecord.PlacesAvailable,
                PlacesReserved = movieRecord.PlacesReserved,
                Genre = _context.Find<GenreTypeRecord>(movieRecord.GenreTypeId).Name
            };
        }

        public async Task InsertMovie(MovieDto movie)
        {
            if ( _context.Find<GenreTypeRecord>(movie.GenreTypeId) == null)
            {
                throw new NotImplementedException();
            }

            var movieRecord = new MovieRecord
            {
                Title = movie.Title,
                Description = movie.Description,
                PlacesAvailable = movie.PlacesAvailable,
                PlacesReserved = movie.PlacesReserved,
                GenreTypeId = movie.GenreTypeId,
                LastModified = DateTime.UtcNow,
                ModifiedBy = "sys"
            };

            await _context.Movies.AddAsync(movieRecord);
            _context.SaveChanges();
        }
    }
}
