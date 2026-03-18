using Catalog.Application.Responses;
using Catalog.Core.Specifications;
using MediatR;

namespace Catalog.Application.Queries
{
    public record GetAllProductQuery(CatalogSpecParams catalogSpecParams) : IRequest<Pagination<ProductResponse>>;
}
