using eSchool.Infrastructure.Dto;
using eSchool.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSchool.Infrastructure.UnitOfWork;

namespace eSchool.Service.Services
{
    public class SubjectService : ISubjectService
    {
        UnitOfWork _unitOfWork;
        public SubjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;   
        }
        
        public SubjectDto GetByName(string name)
        {
            return _unitOfWork._SubjectRepository.GetByName(name);    
        }
    }
}
