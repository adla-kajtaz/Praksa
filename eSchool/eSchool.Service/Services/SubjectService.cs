using eSchool.Infrastructure.Dto;
using eSchool.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Service.Services
{
    public class SubjectService : ISubjectService
    {
        SubjectRepository _repository;
        public SubjectService(SubjectRepository repository)
        {
            _repository = repository;    
        }
        
        public SubjectDto GetByName(string name)
        {
            return _repository.GetByName(name);    
        }
    }
}
