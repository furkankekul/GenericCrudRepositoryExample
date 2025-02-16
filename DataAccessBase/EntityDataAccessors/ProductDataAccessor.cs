using DataAccessBase.GenericDataAccessRepos;
using Entities;

namespace DataAccessBase.EntityDataAccessors
{
    public class ProductDataAccessor : Repository<Product>
    {
        public ProductDataAccessor(ExampleDbContext context) : base(context)
        {
        }
    }
}
