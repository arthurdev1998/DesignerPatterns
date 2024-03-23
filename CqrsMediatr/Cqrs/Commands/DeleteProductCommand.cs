using CqrsMediatr.Dtos;
using MediatR;

namespace CqrsMediatr.Cqrs.Commands;

public class DeleteProductCommand : IRequest<ServiceResult<ProductDto>>
{
    public string? Nome { get; set; }
    public int Id { get; set; }
}