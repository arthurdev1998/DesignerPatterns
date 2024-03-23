using CqrsMediatr.Entities;
using MediatR;

namespace CqrsMediatr.Cqrs.Querys;

public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<Product>>
{
    public Task<List<Product>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new List<Product>()
        {
            new(title: "title0", description: "description0"),
            new(title: "title1", description: "description1"),
            new(title: "title2", description: "description2"),
            new(title: "title3", description: "description3"),
            new(title: "title4", description: "description4"),
            new(title: "title5", description: "description5"),
            new(title: "title6", description: "description6"),
            new(title: "title7", description: "description7"),
            new(title: "title8", description: "description8"),
            new(title: "title9", description: "description9"),
        });
    }
}