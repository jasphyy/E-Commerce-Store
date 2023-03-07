using Ecommerce.Service.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using Ecommerce.Service.Request;
using Ecommerce.Service.Request.Command;
using Ecommerce.Service.Request.Request;

namespace Ecommerce.Service.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class ListingController : ControllerBase
{
    private readonly ILogger<ListingController> _logger;
    private readonly IMediator _mediator;

    public ListingController(
        ILogger<ListingController> logger,
        IMediator mediator
        )
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "Get All Listings")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllListingCommand());

        return Ok(result);
    }

    [HttpPost(Name = "Post Listing")]
    public async Task<IActionResult> Add([FromBody] CreateListingRequest request) 
    {
        if (request == null) 
        { 
            throw new ArgumentNullException(nameof(request));
        }

        var command = new CreateListingCommand(
            request.Name,
            request.Price,
            request.DeliveryMethod,
            request.Status)
        { 
            Description = request.Description,
        };

        var result = await _mediator.Send(command);

        return Ok(result);
    }
}