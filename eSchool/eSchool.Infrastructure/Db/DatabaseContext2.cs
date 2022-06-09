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
        /*private void SeedData(List<Subject> subject)
        {
            subject.Add(new Subject
            {
                Id = 1,
                Name = "Matematika",
                ECTS = 7,
                NumberOfHours = 2,
                IsDeleted = false
            });
        }*/

        private void SeedData(ModelBuilder subject)
        {
            subject.Entity<Subject>().HasData(new Subject
            {
                Id = 1,
                Name = "Matematika",
                ECTS = 7,
                NumberOfHours = 2,
                IsDeleted = false
            });
        }
    }
}
