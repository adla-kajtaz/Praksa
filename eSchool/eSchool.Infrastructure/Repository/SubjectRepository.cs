using eSchool.Core;
using eSchool.Infrastructure.BaseRepository;
using eSchool.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure
{
    public class SubjectRepository : BaseRepository<Subject, int>, ISubjectRepository
    {
        public SubjectRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public SubjectDto GetByName(string name)
        {
            var data=_dbSet.Where(x => x.Name == name).FirstOrDefault();
            var subject = new SubjectDto()
            {
                Name = data.Name,
                ECTS = data.ECTS,
                NumberOfHours = data.NumberOfHours
            };
                
            return subject;
        }
    }
}
