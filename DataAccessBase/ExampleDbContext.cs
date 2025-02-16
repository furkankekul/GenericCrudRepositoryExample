using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessBase
{
    public class ExampleDbContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
