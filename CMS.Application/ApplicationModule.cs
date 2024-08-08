using Autofac;
using CMS.Application.Features.Training;
using CMS.Domain.Features.Training;


namespace CMS.Application
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseManagementService>().As<ICourseManagementService>()
                 .InstancePerLifetimeScope();
        }
    }
}
