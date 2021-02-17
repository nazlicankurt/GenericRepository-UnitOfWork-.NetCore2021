using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public interface IUnitOfWork : IDisposable
        {
            IRepository<T> GetRepository<T>() where  T : class;
            int SaveChanges();
        }
    }
}
