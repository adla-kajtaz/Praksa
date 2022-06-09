using eSchool.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Infrastructure
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options):base (options)
        {

        }

        public DbSet<Subject> Subjects { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var subject = (List<Subject>)modelBuilder.Model;
            //SeedData(subject);
            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ModifyTimeStamp();
            return base.SaveChanges();
        }

        private void ModifyTimeStamp()
        {
            var entities = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));
            foreach (var entity in entities)
            {
                if(entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.Now;   
                }
                else if(entity.State == EntityState.Modified)
                {
                    ((BaseEntity)entity.Entity).ModifiedAt = DateTime.Now;
                }
            }

        }

    }
}
