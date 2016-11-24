using Autofac;
using MongoTodo.Services.DependencyInjection;

namespace MongoTodo.DependencyInjection
{
    public static class Registration
    {
        public static void RegisterWeb(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterServices();
        }
    }
}