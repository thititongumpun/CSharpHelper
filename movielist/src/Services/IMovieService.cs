using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imdbx.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movies>> GetMoviesList();
        Task<Movies> GetMoviesByGuid(Guid id);
        Task AddMovie(Movies movies);
    }
}
