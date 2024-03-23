using CqrsMediatr.Dtos;
using CqrsMediatr.Entities;
using MediatR;

namespace CqrsMediatr.Cqrs.Commands;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResult<ProductDto>>
{
    public Task<ServiceResult<ProductDto>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var random = new Random();

        var response = new ProductDto
        {
            Id = random.Next(),
            Name = request.Name,
            Description = "Description",
            HourOpen = DateTime.Now
        };

        return Task.FromResult(new ServiceResult<ProductDto>(response));
    }
}