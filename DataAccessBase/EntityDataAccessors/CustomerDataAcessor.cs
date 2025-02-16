using DataAccessBase.GenericDataAccessRepos;
using Entities;

namespace DataAccessBase.EntityDataAccessors
{
    public class CustomerDataAcessor : Repository<Customer>
    {
        public CustomerDataAcessor(ExampleDbContext context) : base(context)
        {
        }
    }
}
