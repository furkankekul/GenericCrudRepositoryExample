using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DataAccessBase.GenericDataAccessRepos
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ExampleDbContext _context;
        public Repository(ExampleDbContext context)
        {
            _context = context;

        }
        public bool BulkDelete(List<T> list)
        {
            _context.Set<T>().RemoveRange(list);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool BulkInsert(List<T> list)
        {
            _context.Set<T>().AddRange(list);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool BulkUpdate(List<T> list)
        {
            _context.Set<T>().UpdateRange(list);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(T model)
        {
            _context.Set<T>().Remove(model);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public List<T> GetAllList()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public List<T> GetListWithPredicate(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public bool Insert(T model)
        {
            _context.Set<T>().Add(model);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Update(T model)
        {
            _context.Set<T>().Update(model);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}
