using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DAL
{
    public interface IDataBaseTransaction :IDisposable
    {
        void Commit();
        void Rollback();
    }
}
