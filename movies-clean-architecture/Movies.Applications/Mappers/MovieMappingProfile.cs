using AutoMapper;
using Movies.Applications.Commands.Movie;
using Movies.Applications.Responses.Movie;
using Movies.Core.Entities;

namespace Movies.Applications.Mappers
{
    public class MovieMappingProfile : Profile
    {
        public MovieMappingProfile()
        {
            CreateMap<Movie, MovieResponse>().ReverseMap();
            //CreateMap<Movie, CreateMovieCommand>().ReverseMap();
            CreateMap<CreateMovieCommand, Movie>().ReverseMap();
        }
    }
}
