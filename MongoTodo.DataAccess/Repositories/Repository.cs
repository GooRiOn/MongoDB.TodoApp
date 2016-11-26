using System.Threading.Tasks;
using MongoDB.Driver;
using MongoTodo.DataAccess.Documents.Interfaces;
using MongoTodo.DataAccess.Repositories.Interfaces;

namespace MongoTodo.DataAccess.Repositories
{
    public abstract class Repository<TDocument> : IRepository<TDocument> where TDocument: IBaseDocument
    {
        protected IMongoCollection<TDocument> Collection => Context.Database.GetCollection<TDocument>(nameof(TDocument));

        private TodoContext Context { get; }

        internal Repository(TodoContext context)
        {
            Context = context;
        }

        public async Task InsertOneAsync(TDocument document)
            => await Collection.InsertOneAsync(document);
    }
}