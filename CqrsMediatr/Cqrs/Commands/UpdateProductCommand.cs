using CqrsMediatr.Dtos;
using MediatR;

namespace CqrsMediatr.Cqrs.Commands;

public class UpdateProductCommand : IRequest<ServiceResult<ProductDto>>
{
    public string? Name { get; set; }
    public int? Price { get; set; }
}