using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public interface IRepository<TEntity>
        where TEntity:class,new()
    {
        List<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        void HardDelete(Expression<Func<TEntity, bool>> expression);
        void Delete(Expression<Func<TEntity, bool>> expression);
        void Update(TEntity entity);
        void Add(TEntity entity);
    }
}
