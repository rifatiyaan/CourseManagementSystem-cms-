using CMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Features.Training
{
    public interface ICourseManagementService
    {
        Task CreateCourseAsync(string title, uint fees, string description);

        Task<(IList<Course> records, int total, int totalDisplay)>
           GetPagedCoursesAsync(int pageIndex, int pageSize, string searchText,
           string sortBy);
        Task DeleteCourseAsync(Guid id);
        Task<Course> GetCourseAsync(Guid id);
        Task UpdateCourseAsync(Guid id, string title, string description, uint fees);
    }
}
