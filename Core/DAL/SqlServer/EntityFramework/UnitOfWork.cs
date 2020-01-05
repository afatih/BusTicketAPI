using Core.Exceptions;
using Core.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.DAL;

namespace Core.DAL.SqlServer.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        //Bu kısma İnejcte edilen DB yazıldı normalde sadece DbContext idi.
        private readonly TicketDBContext _dbContext;
        public UnitOfWork(TicketDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IDataBaseTransaction BeginTransaction()
        {
            return new EntityDatabaseTransaction(_dbContext);
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, new()
        {
            return new Repository<TEntity>(_dbContext);
        }

        public int Save()
        {
            int ess;
            try
            {
                ess = _dbContext.SaveChanges();
                if (ess > 0)
                {
                    return ess;
                }
                else
                {
                    throw new AppException("İşlem başarısız");
                }

            }
            catch (Exception ex)
            {
                throw new AppException(ex.Message);
            }
        }

        public ServiceResult _Save()
        {
          IDbContextTransaction transaction=  _dbContext.Database.BeginTransaction();
            int ess=0;
            try
            {
              ess=  _dbContext.SaveChanges();
                transaction.Commit();
                if (ess>0)
                {
                    return new ServiceResult(ProcessStateEnum.Success, "İşlem başarılı");
                }
                else
                {
                    return new ServiceResult(ProcessStateEnum.Warning, "İşlem başarısız");
                }
                
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return new ServiceResult(ProcessStateEnum.Error, ex.Message);
            }
        }
    }
}
