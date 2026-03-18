using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Queries
{
    public record GetProductsByBrandQuery(string brandName) : IRequest<IList<ProductResponse>>;

}
