using Microsoft.AspNetCore.Mvc;
using movie_reservation_app.Dtos;
using movie_reservation_app.Service;
using System;
using System.Threading.Tasks;

namespace movie_reservation_app.Controllers
{

    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            return Ok(await _service.GetAllMovies());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            return Ok(await _service.GetMovieById(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertMovie(MovieDto movie)
        {
            await _service.InsertMovie(movie);
            return Ok();
        }
    }
}