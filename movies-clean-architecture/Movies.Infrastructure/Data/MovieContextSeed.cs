using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Movies.Core.Entities;

namespace Movies.Infrastructure.Data
{
    public class MovieContextSeed
    {
        public static async Task SeedAsync(MovieDbContext context ,ILoggerFactory loggerFactory,int? retry=0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                await context.Database.EnsureCreatedAsync();
                //  await context.Database.MigrateAsync();
                if (!context.Movies.Any())
                {
                    context.Movies.AddRangeAsync(GetMovies());
                  await  context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability<3)
                {
                    retryForAvailability++;
                    var log=loggerFactory.CreateLogger<MovieContextSeed>();
                    log.LogError($"Exception while seeding default data :{ex.Message}");
                    await SeedAsync(context,loggerFactory,retryForAvailability);
                }
               // throw;
            }
        }
        private static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie("Movie Name 1","director Name 1" ,"relase Year 1" ),
                new Movie("Movie Name 2","director Name 2" ,"relase Year 2" ),
                new Movie("Movie Name 3","director Name 3" ,"relase Year 3" ),
            };
        }
    }
}
