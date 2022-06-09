using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure.UnitOfWork
{
    public class UnitOfWork<TEntity> : IUnitOfWork where TEntity : class
    {
        protected DatabaseContext _dbContext;
        public ISubjectRepository _SubjectRepository { get; set; }
        //protected DbSet<TEntity> _dbSet;

        public UnitOfWork(DatabaseContext dbContext, ISubjectRepository SubjectRepository)
        {
            _dbContext = dbContext;
            _SubjectRepository = SubjectRepository;
        }

        public void Begin()
        {
            _dbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbContext.Database.CommitTransaction();
        }

        public void Roolback()
        {
            _dbContext.Database.RollbackTransaction();
        }
    }
}
