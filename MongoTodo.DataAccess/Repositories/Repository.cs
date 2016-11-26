using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoTodo.DataAccess.Documents.Interfaces;
using MongoTodo.DataAccess.Repositories.Interfaces;

namespace MongoTodo.DataAccess.Repositories
{
    internal abstract class Repository<TDocument> : IRepository<TDocument> where TDocument: IBaseDocument
    {
        protected IMongoCollection<TDocument> Collection => Context.Database.GetCollection<TDocument>($"{DocumentType.Name}s");
        private Type DocumentType { get; } = typeof(TDocument);

        TodoContext Context { get; }

        protected Repository(TodoContext context)
        {
            Context = context;
        }

        public async Task InsertOneAsync(TDocument document)
            => await Collection.InsertOneAsync(document);
    }
}