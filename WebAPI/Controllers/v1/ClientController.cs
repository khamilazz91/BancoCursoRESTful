using Application.Features.Commands.CreateClientCommand;
using Application.Features.Commands.DeleteClientCommand;
using Application.Features.Commands.UpdateClientCommand;
using Application.Features.Queries.Get;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{

    [ApiVersion("1.0")]
    public class ClientController : BaseApiController
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetClientByIdQuery { Id = id }));
        }


        [HttpPost]
        public async Task<IActionResult> Post(CreateClientCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateClientCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteClientCommand { Id = id }));
        }
    }
}
