using OZamanDans.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.Core.DataAccess
{
    //note generic repositorynin ilk kuralı generic bir repsitory interface i oluşturmak
    public interface IEntityRepository<TEntity>
        where TEntity : IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter);

        //note Func => Birden fazla parametre alabilen geriye generic dönen metotlar taşır.
        //note Predicate => geriye bool dönen metotlar taşır.
        //note Action

        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

    }
}
