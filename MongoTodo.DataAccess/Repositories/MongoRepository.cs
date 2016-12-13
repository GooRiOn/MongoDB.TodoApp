using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoTodo.DataAccess.Documents.Interfaces;
using MongoTodo.DataAccess.Repositories.Interfaces;

namespace MongoTodo.DataAccess.Repositories
{
    internal abstract class MongoRepository<TDocument> : IRepository<TDocument> where TDocument: IBaseDocument
    {
        protected IMongoCollection<TDocument> Collection => _context.Database.GetCollection<TDocument>($"{DocumentType.Name}s");
        private static Type DocumentType { get; } = typeof(TDocument);

        private readonly TodoContext _context;

        protected MongoRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task InsertOneAsync(TDocument document)
            => await Collection.InsertOneAsync(document);

        public async Task<TDocument> GetByIdAsync(int id)
            => await Collection.Find(d => d.Id == id).FirstOrDefaultAsync();
    }
}