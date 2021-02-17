using GenericRepository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericRepository.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
      
        private readonly ProductContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ProductContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = _dbContext.Set<T>();

        }
        public T Get(int id)
        {
            return _dbSet.Find(id);
        }
     
        public void Delete(int id)
        {
            var entity = Get(id);
            _dbSet.Remove(entity);
        }
        public IQueryable<T> All()
        {
            return _dbSet.AsNoTracking();
            /**asnotracking veritabanından sorgu neticesinde elde edilen nesnelerin takip mekanizması ilgili fonksiyon tarafından kırılarak, sistem tarafından izlenmelerine son verilmesini sağlamakta ve böylece tüm verisel varlıkların ekstradan işlenme yahut lüzumsuz depolanma süreçlerine maliyet ayrılmamaktadır.**/
        }
        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public Guid Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            _dbContext.Entry<T>(entity).State = EntityState.Modified;

        }
    }
    //public int Update(int entity)
    //{
    //    _dbSet.Attach(entity);
    //    _dbContext.Entry(entity).State = EntityState.Modified;
    //}
}
