using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator
        {
            get
            {
                if (_mediator == null)
                {
                    var mediators = HttpContext.RequestServices.GetServices<IMediator>();
                    _mediator = mediators.FirstOrDefault(); // Get the first IMediator instance or null if the collection is empty  
                }
                return _mediator;
            }
        }
    }
}

