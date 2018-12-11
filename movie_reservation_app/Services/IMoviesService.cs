using movie_reservation_app.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_reservation_app.Service
{
    public interface IMoviesService
    {
        Task<IEnumerable<MovieDto>> GetAllMovies();
        Task<MovieDto> GetMovieById(int id);
        Task InsertMovie(MovieDto movie);
    }
}
