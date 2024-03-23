using CqrsMediatr.Dtos;
using MediatR;

namespace CqrsMediatr.Cqrs.Commands;

public class CreateProductCommand :IRequest<ServiceResult<ProductDto>>
{
    public string? Name { get; set; }
    public int Price { get; set; }
}