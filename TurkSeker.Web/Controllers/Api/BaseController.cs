
using MediatR;
using System.Web;
using System.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace TurkSeker.Web.Controllers.Api
{
    [Route("api/[controller]")]
     
    public class BaseController : ControllerBase

    {
        private readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override void ExecuteCore()
        {
            throw new System.NotImplementedException();
        }
    }
}
