using eSchool.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure
{
    public interface ISubjectRepository
    {
        SubjectDto GetByName(string name);
    }
}
