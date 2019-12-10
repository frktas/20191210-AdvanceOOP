using OZamanDans.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.Core.DataAccess.EntityFramework
{
    class EFRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        TContext _tContext;
        public EFRepositoryBase()
        {
            _tContext = new TContext();
        }
        public void Add(TEntity entity)
        {
            _tContext.Entry(entity).State = EntityState.Added;
            _tContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _tContext.Entry(entity).State = EntityState.Deleted;
            _tContext.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _tContext.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return _tContext.Set<TEntity>().ToList();
            }
            else
            {
                return _tContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            _tContext.Entry(entity).State = EntityState.Modified;
            _tContext.SaveChanges();
        }
    }
}
