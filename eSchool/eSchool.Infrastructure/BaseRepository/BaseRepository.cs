using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure.BaseRepository
{
    public abstract class BaseRepository<TEntity, TPrimaryKey> : IBaseRepository<TEntity, TPrimaryKey> where TEntity : class
    {
        protected readonly DatabaseContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        public BaseRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;  
            _dbSet = _dbContext.Set<TEntity>(); 
        }

        public List<TEntity> Get()
        {
            return _dbSet.ToList();
        }
    }
}
