using System.Linq.Expressions;

namespace TemplateData.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        object DelegateSettings { get; }
        TEntity Settings { get; set; }
        string Type { get; }

        List<TEntity> Create(List<TEntity> models);
        TEntity Create(TEntity model);
        Task<TEntity> CreateAsync(TEntity model);
        bool Delete(Expression<Func<TEntity, bool>> where);
        bool Delete(params object[] Keys);
        bool Delete(TEntity model);
        Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> where);
        Task<bool> DeleteAsync(params object[] Keys);
        Task<bool> DeleteAsync(TEntity model);
        void Dispose();
        TEntity Find(Expression<Func<TEntity, bool>> where);
        TEntity Find(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes);
        TEntity Find(params object[] Keys);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetAsync(params object[] Keys);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes);
        int Save();
        Task<int> SaveAsync();
        bool Update(List<TEntity> models);
        bool Update(TEntity model);
        Task<bool> UpdateAsync(TEntity model);
    }
}