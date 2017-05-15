using Autofac;
using Services.ContentsServices;
using Services.DBCodesServices;
using Services.ImagesServices;
using Services.MessagesServices;

namespace Fifm.Services.DependencyResolvers.Autofac
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ImagesServices>().As<IImagesServices>().SingleInstance();
            builder.RegisterType<ContentsServices>().As<IContentsServices>().SingleInstance();
            builder.RegisterType<DBCodesServices>().As<IDBCodesServices>().SingleInstance();
            builder.RegisterType<MessagesServices>().As<IMessagesServices>().SingleInstance();
        }
    }
}
