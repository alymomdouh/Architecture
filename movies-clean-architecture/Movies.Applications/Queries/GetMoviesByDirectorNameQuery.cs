using MediatR;
using Movies.Applications.Responses.Movie;

namespace Movies.Applications.Queries
{
    public class GetMoviesByDirectorNameQuery : IRequest<IEnumerable<MovieResponse>>
    {
        public string DirectorName { get; set; }

        public GetMoviesByDirectorNameQuery(string directorName)
        {
            DirectorName = directorName;
        }
    }
}
