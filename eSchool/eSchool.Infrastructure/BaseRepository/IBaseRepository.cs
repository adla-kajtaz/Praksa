using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure.BaseRepository
{
    public interface IBaseRepository <TEntity,TPrimaryKey> where TEntity : class
    {
        List<TEntity> Get();
    }
}
