using MediatR;
using Movies.Applications.Mappers;
using Movies.Applications.Queries;
using Movies.Applications.Responses.Movie;
using Movies.Core.Repositories;

namespace Movies.Applications.Handlers.MovieHandler
{
    public class GetMoviesByDirectorNameHandler : IRequestHandler<GetMoviesByDirectorNameQuery, IEnumerable<MovieResponse>>
    {
        private readonly IMovieRepository _movieRepository;
        public GetMoviesByDirectorNameHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<IEnumerable<MovieResponse>> Handle(GetMoviesByDirectorNameQuery request, CancellationToken cancellationToken)
        {
            var moviesList = await _movieRepository.GetMoviesByDirectorName(request.DirectorName);
            var movieResponseList= MovieMapper.Mapper.Map<IEnumerable<MovieResponse>>(moviesList);
            return movieResponseList;
        }
    }
}
