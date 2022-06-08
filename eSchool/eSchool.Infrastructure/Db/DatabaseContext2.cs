using eSchool.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure
{
    public partial class DatabaseContext
    {
        private void SeedData(List<Subject> subject)
        {
            subject.Add(new Subject
            {
                Name = "Test",
                ECTS = 7,
                NumberOfHours = 2
            });
        }
    }
}
