using OriseProfile.Application.Commands;
using OriseProfile.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace OriseProfile.Presentation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Submit([FromBody] SubmitPersonCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}