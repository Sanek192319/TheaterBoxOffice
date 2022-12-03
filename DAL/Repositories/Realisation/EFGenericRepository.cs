using DAL.Entites;
using DAL.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realisation
{
    public class EFGenericRepository<T, KId> : IRepository<T, KId> where T : BaseEntity<KId>
    {
        protected readonly TheaterBoxOfficeDbContext _dbContext;
        protected readonly DbSet<T> _entities;

        public EFGenericRepository(TheaterBoxOfficeDbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _entities = dbSet;
        }

        public void Create(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public T GetById(KId id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsNoTracking();
        }
    }
}
