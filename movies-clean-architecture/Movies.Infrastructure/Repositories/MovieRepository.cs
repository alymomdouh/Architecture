using Microsoft.EntityFrameworkCore;
using Movies.Core.Entities;
using Movies.Core.Repositories;
using Movies.Infrastructure.Data;
using Movies.Infrastructure.Repositories.Base;

namespace Movies.Infrastructure.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieDbContext context) : base(context)
        {
        } 
        public async Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName)
        { 
            return await _context.Movies
                                 .Where(item => item.DirectorName.Trim().Equals(directorName.Trim(), 
                                                                                    StringComparison.OrdinalIgnoreCase))
                                 .ToListAsync();
        }
    }
}
