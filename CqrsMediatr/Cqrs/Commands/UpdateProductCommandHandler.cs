using CqrsMediatr.Dtos;
using MediatR;

namespace CqrsMediatr.Cqrs.Commands;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ServiceResult<ProductDto>>
{
    public Task<ServiceResult<ProductDto>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
       if (request.Price == null)
            throw new ArgumentNullException(nameof(request.Price));

        var response = new ProductDto() 
        {
            Id = new Random().Next(1, 99),
            Price = request.Price.Value,
            Name = request.Name,
            Description = "DescricaoAtualizada",
            HourOpen = DateTime.UtcNow
        };

        return Task.FromResult(new ServiceResult<ProductDto>(response));
    }
}