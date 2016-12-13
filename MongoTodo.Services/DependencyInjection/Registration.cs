using Autofac;
using MongoTodo.DataAccess.DependencyInjection;
using MongoTodo.Services.Services;
using MongoTodo.Services.Services.Interfaces;

namespace MongoTodo.Services.DependencyInjection
{
    public static class Registration
    {
        public static void RegisterServices(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterDataAcces();

            containerBuilder.RegisterType<CardService>().As<ICardService>();
        }
    }
}