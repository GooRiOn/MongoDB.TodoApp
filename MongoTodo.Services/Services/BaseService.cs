using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoTodo.DataAccess.Documents.Interfaces;
using MongoTodo.DataAccess.Repositories.Interfaces;
using MongoTodo.Services.Services.Interfaces;


namespace MongoTodo.Services.Services
{
    public abstract class BaseService<TDocument, TRepository> : IBaseService<TDocument> where TDocument : IBaseDocument where TRepository : IRepository<TDocument>
    {
        protected TRepository Repository { get; }

        protected BaseService(TRepository repository)
        {
            Repository = repository;
        }

        public async Task InsertOneAsync(TDocument document)
            => await Repository.InsertOneAsync(document);

        public async Task<TDocument> GetByIdAsync(int id)
            => await Repository.GetByIdAsync(id);

        public async Task<IEnumerable<TDocument>> GetFilteredAsync(Expression<Func<TDocument, bool>> predicate)
            => await Repository.GetFilteredAsync(predicate);
    }
}