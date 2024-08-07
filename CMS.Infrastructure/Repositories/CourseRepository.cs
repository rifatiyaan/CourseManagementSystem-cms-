using Demo_Crud.Domain.Entities;
using Demo_Crud.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Crud.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course, Guid>, ICourseRepository
    {
        public CourseRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }

        public async Task<bool> IsTitleDuplicateAsync(string title, Guid? id = null)
        {
            if (id.HasValue)
            {
                return (await GetCountAsync(x => x.Id != id.Value && x.Title == title)) > 0;
            }
            else
            {
                return (await GetCountAsync(x => x.Title == title)) > 0;
            }

        }

        public async Task<(IList<Course> records, int total, int totalDisplay)>
           GetTableDataAsync(string searchText, string orderBy,
               int pageIndex, int pageSize)
        {
            return await GetDynamicAsync(x => x.Title.Contains(searchText),
                orderBy, null, pageIndex, pageSize, true);
        }

    }
}
