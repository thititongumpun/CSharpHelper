using imdbx.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imdbx.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Movies> GetMoviesByGuid(Guid id)
        {
            return await _context.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Movies>> GetMoviesList()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task AddMovie(Movies movies)
        {
            await _context.Movies.AddAsync(movies);
            await _context.SaveChangesAsync();
        }
    }
}
