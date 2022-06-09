using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        public void Commit();
        public void Roolback();
        public void Begin();
        public ISubjectRepository _SubjectRepository { get; set; }

    }
}
