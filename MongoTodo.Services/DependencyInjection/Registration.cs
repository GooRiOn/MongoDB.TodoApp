using Autofac;
using MongoTodo.DataAccess.DependencyInjection;

namespace MongoTodo.Services.DependencyInjection
{
    public static class Registration
    {
        public static void RegisterServices(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterDataAcces();
        }
    }
}