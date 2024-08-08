using CMS.Domain;
using CMS.Domain.Repositories;

namespace CMS.Application
{

    public interface IApplicationUnitOfWork : IUnitOfWork
    {

        ICourseRepository CourseRepository { get; }

    }
}
