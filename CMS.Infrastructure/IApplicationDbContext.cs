using Demo_Crud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Crud.Infrastructure
{
    public interface IApplicationDbContext
    {
        DbSet<Course> Courses { get; set; }
    }
}
