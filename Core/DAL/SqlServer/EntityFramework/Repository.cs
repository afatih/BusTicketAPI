using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL.SqlServer.EntityFramework
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
    {
        DbContext _dbContext;
        DbSet<TEntity> _dbset;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbset = _dbContext.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public void HardDelete(Expression<Func<TEntity, bool>> expression)
        {
            List<TEntity> silinecekler = Get(expression);
            _dbset.RemoveRange(silinecekler);
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            return ((IQueryable<TEntity>)_dbset).Where(expression).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Expression<Func<TEntity, bool>> expression)
        {
            List<TEntity> silinecekler = Get(expression);
            foreach (var item in silinecekler)
            {
                PropertyInfo info = item.GetType().GetProperty("IsDeleted");
                if (info != null)
                {
                    info.SetValue(item, true);
                    Update(item);
                }
            }

        }
    }
}
