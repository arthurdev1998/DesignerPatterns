

using CqrsMediatr.Dtos;
using CqrsMediatr.Entities;
using MediatR;

namespace CqrsMediatr.Cqrs.Commands;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ServiceResult<ProductDto>>
{
    public Task<ServiceResult<ProductDto>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var collection = new List<Product>
        {
            new(title: "livro1", description: "descricaodolivro"){}
        };
        Console.WriteLine("livr1 adicionado");

        var productaserremovido = collection.FirstOrDefault(x => x.Title == request.Nome);
        if (productaserremovido != null)
        {
            collection.Remove(productaserremovido);
            return Task.FromResult(new ServiceResult<ProductDto>());
        }

        return Task.FromResult(new ServiceResult<ProductDto>());
    }
}