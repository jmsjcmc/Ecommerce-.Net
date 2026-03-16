using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Repositories
{
    public class TypeRepository: ITypeRepository
    {
        private readonly IMongoCollection<Pr>
        public TypeRepository(IConfiguration config)
        {
            
        }

        public Task<IEnumerable<ProductType>> GetAllTypes()
        {
            throw new NotImplementedException();
        }

        public Task<ProductType> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
