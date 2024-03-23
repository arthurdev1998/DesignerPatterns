using System.Diagnostics;
using CqrsMediatr.Cqrs.Commands;
using CqrsMediatr.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CqrsMediatr.Controller;

[Route("[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public ActionResult<ServiceResult<ProductDto>> GetProducts(CreateProductCommand command)
    {
        var response = _mediator.Send(command);
        return Ok(response.Result.Data);
    }
}
