using Autofac;
using CMS.Areas.Admin.Models;


namespace CMS
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            builder.RegisterType<CourseCreateModel>().AsSelf();
            builder.RegisterType<CourseListModel>().AsSelf();
            builder.RegisterType<CourseUpdateModel>().AsSelf();
        }
    }
}
