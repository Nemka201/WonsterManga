using System.Linq.Expressions;

namespace Noticias.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        public void Attach(T entity);

        List<T> GetAll();
        List<T> FindBy(Expression<Func<T, bool>> predicate);
        bool Add(T entity);
        bool Delete(T entity);
        bool Edit(T entity);
        bool Save();
        bool SaveChanges(T entity);
        T FindById(int id);
        void AddRange(IEnumerable<T> entities);

        // Async methods

        Task<List<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<int> GetCountAsync();
        Task<List<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task SaveAsync();
        Task SaveChangesAsync(T entity);
        Task<T> FindByIdAsync(int id);
        Task<List<T>> GetByIndexAsync(int pageIndex);

        // Devuelve de manera indexada pageSize de elementos
        Task<List<T>> GetByIndexAsync(int pageIndex, int pageSize);
        // Devuelve ordenaro por los ultimos elementos de manera indexada pageSize elementos
        Task<List<T>> GetByDateAsync(Expression<Func<T, DateTime>> dateSelector, int pageIndex, int pageSize); 

    }
}
