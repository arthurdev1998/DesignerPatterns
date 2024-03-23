using CqrsMediatr.Entities;
using MediatR;

namespace CqrsMediatr.Cqrs.Querys;

public class GetAllQuery : IRequest<List<Product>>
{
    
}