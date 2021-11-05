using imdbx.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imdbx.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieListController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieListController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return Ok(await _movieService.GetMoviesList());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMoviesByGuid([FromRoute] Guid id)
        {
            return Ok(await _movieService.GetMoviesByGuid(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie([FromBody] Movies movies)
        {
            await _movieService.AddMovie(movies);
            return Ok(movies);
        }
    }
}
