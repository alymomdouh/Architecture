using MediatR;
using Movies.Applications.Responses.Movie;

namespace Movies.Applications.Commands.Movie
{
    public class CreateMovieCommand : IRequest<MovieResponse>
    {
    }
}
