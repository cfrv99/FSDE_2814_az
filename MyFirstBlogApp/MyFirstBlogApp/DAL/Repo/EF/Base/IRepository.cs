using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DAL.Repo.EF.Base
{
    public interface IRepository<TEntity> where TEntity:class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);

        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(int id);
        IQueryable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includes);
    }
}
