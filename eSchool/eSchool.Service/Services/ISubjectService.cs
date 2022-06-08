using eSchool.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Service.Services
{
    public interface ISubjectService
    {
        SubjectDto GetByName(string name);
    }
}
