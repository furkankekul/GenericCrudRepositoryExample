using System.Linq.Expressions;

namespace DataAccessBase.GenericDataAccessRepos
{
    public interface IRepository<T> where T : class
    {
        public bool Insert(T model);
        public bool BulkInsert(List<T> list);
        public bool Delete(T model);
        public bool BulkDelete(List<T> list);
        public bool Update(T model);
        public bool BulkUpdate(List<T> list);
        public List<T> GetAllList();
        public List<T> GetListWithPredicate(Expression<Func<T, bool>> predicate);

    }
}
