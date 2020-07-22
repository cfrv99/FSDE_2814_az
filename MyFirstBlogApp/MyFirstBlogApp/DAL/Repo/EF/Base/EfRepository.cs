using Microsoft.EntityFrameworkCore;
using MyFirstBlogApp.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DAL.Repo.EF.Base
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        DbSet<TEntity> Table;
        private readonly AppDbContext context;
        public EfRepository(AppDbContext context)
        {
            this.context = context;
            Table = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            Table.Add(entity);
            var a = context.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = GetById(id);
            Table.Remove(result);
            context.SaveChanges();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            var result = Table.Where(predicate).AsQueryable();
            return result;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Table.AsQueryable();
        }

        public TEntity GetById(int id)
        {
            return Table.Find(id);
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public IQueryable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = GetAll();
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        
    }
}
