using MediatR;
using Microsoft.AspNetCore.Mvc;
using Movies.Applications.Commands.Movie;
using Movies.Applications.Queries;

namespace Movies.API.Controllers
{
    public class MovieController : APIController
    {
        private readonly IMediator _mediator;
        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetMoviesByDirectorName")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMoviesByDirectorNameAsync(string directorName)
        {
            return Ok(await _mediator.Send(new GetMoviesByDirectorNameQuery(directorName)));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateMovie([FromBody] CreateMovieCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
