using MongoDB.Driver;

namespace MongoTodo.DataAccess
{    
    internal class TodoContext
    {
        internal IMongoDatabase Database { get; }

        public TodoContext()
        {
            var client = new MongoClient("mongodb://localhost");
            Database = client.GetDatabase("todo");
        }
    }
}
