using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Core
{
    public class Subject : BaseEntity, ISubject
    {
        public string Name { get; set; }
        public int NumberOfHours { get; set; }
        public int ECTS { get; set; }
    }
}
