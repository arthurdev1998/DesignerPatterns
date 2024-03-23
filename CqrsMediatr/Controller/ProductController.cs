using System.Diagnostics;
using CqrsMediatr.Cqrs.Commands;
using CqrsMediatr.Cqrs.Querys;
using CqrsMediatr.Dtos;
using CqrsMediatr.Entities;
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
    [ProducesResponseType(typeof(ProductDto), 200)]
    public ActionResult<ServiceResult<ProductDto>> GetProducts(CreateProductCommand command)
    {
        var response = _mediator.Send(command);
        return Ok(response.Result.Data);
    }

    [HttpPut]
    [ProducesResponseType(typeof(ProductDto), 200)]
    public ActionResult<ServiceResult<ProductDto>> UpdateProduct(UpdateProductCommand command)
    {
        var response = _mediator.Send(command);
        return Ok(response.Result.Data);
    }

    [HttpDelete]
    public ActionResult DeleteProduct(DeleteProductCommand command)
    {
        var response = _mediator.Send(command);
        return Ok(response.Result.Data);
    }

    [HttpGet]
    public ActionResult<List<Product>> GetAllProducts()
    {
        var response = _mediator.Send(new GetAllQuery());
        return Ok(response.Result);
    }
}
