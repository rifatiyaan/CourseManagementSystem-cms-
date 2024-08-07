using Demo_Crud.Application;
using Demo_Crud.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Crud.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public ICourseRepository CourseRepository {  get; private set; }

        public ApplicationUnitOfWork(ICourseRepository courseRepository, IApplicationDbContext
            dbContext) : base((DbContext)dbContext)
        {
            CourseRepository = courseRepository;
        }
    }
}
