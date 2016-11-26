using Autofac;
using MongoTodo.DataAccess.Repositories;
using MongoTodo.DataAccess.Repositories.Interfaces;

namespace MongoTodo.DataAccess.DependencyInjection
{
    public static class Registration
    {
        public static void RegisterDataAcces(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<TodoContext>().AsSelf();
            containerBuilder.RegisterType<CardMongoRepository>().As<ICardRepository>();
        }
    }
}