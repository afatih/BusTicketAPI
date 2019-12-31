using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public interface IUnitOfWork
    {
        ServiceResult Save();
        IRepository<TEntity> GetRepository<TEntity>() where TEntity:class,new(); //factory pattern
        
    }
}
