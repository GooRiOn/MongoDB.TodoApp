using Autofac;

namespace MongoTodo.DataAccess.DependencyInjection
{
    public static class Registration
    {
        public static void RegisterDataAcces(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<TodoContext>().AsSelf();
        }
    }
}