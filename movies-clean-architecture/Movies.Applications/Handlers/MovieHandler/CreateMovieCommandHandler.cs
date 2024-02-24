using MediatR;
using Movies.Applications.Commands.Movie;
using Movies.Applications.Mappers;
using Movies.Applications.Responses.Movie;
using Movies.Core.Entities;
using Movies.Core.Repositories;

namespace Movies.Applications.Handlers.MovieHandler
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, MovieResponse>
    {
        private readonly IMovieRepository _movieRepository;
        public CreateMovieCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<MovieResponse> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var movieEntity = MovieMapper.Mapper.Map<Movie>(request);
            if (movieEntity is null)
            {
                throw new ApplicationException("There Is an Issue With Mapper ....");
            }
            var newMoive = await _movieRepository.AddAsync(movieEntity);
            var movieResponse = MovieMapper.Mapper.Map<MovieResponse>(newMoive);
            return movieResponse;
        }
    }
}
