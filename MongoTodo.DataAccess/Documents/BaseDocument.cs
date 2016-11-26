using MongoDB.Bson.Serialization.Attributes;
using MongoTodo.DataAccess.Documents.Interfaces;

namespace MongoTodo.DataAccess.Documents
{
    public abstract class BaseDocument : IBaseDocument
    {
        [BsonId]
        public int Id { get; set; }
    }
}