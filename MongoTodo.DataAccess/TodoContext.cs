using MongoDB.Driver;
using MongoTodo.DataAccess.Models;

namespace MongoTodo.DataAccess
{    
    internal class TodoContext
    {
        private readonly IMongoDatabase _database;

        internal IMongoCollection<Task> Tasks => _database.GetCollection<Task>("tasks");

        internal TodoContext()
        {
            var client = new MongoClient("mongodb://localhost");
            _database = client.GetDatabase("todo");
        }
    }
}
