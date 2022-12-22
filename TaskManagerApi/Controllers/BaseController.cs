using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<ActionResult> ExecuteCommand(Func<Task> command)
        {
            await command.Invoke();
            return Accepted();
        }

        protected async Task<ActionResult> ExecuteQuery<TResult>(Func<Task<TResult>> query)
        {
            var result = await query.Invoke();
            return Ok(result);
        }
    }
}
