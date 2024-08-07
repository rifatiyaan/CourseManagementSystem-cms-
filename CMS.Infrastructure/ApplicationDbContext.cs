using Demo_Crud.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Crud.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {

        private readonly string _connectionString;
        private readonly string _migrationAssembly;

        public ApplicationDbContext(string connectionString, string migrationAssembly)
        {
            _connectionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString,
                    x => x.MigrationsAssembly(_migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course>().HasData(new Course[]
            {
                new Course{Id = Guid.NewGuid(), Title="Test physics course", Description="This is test physics course"},
                new Course{Id = Guid.NewGuid(), Title="Test physics course", Description="This is test physics course",Fees=190}
            });
            base.OnModelCreating(builder);
        }
        public DbSet<Course> Courses { get; set; }
    }
}
