using GenericRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericRepository.Repositories
{

    public interface IGenericRepository<T> where T : class
    {
        Guid Save(T entity);
        T Get(int id);
        void Delete(int id);
        void Update(T entity);
        void Add(T id);
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }

}
