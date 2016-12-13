using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoTodo.DataAccess.Documents.Interfaces;

namespace MongoTodo.Services.Services.Interfaces
{
    public interface IBaseService<TDocument> where TDocument : IBaseDocument
    {
        Task InsertOneAsync(TDocument document);
        Task<TDocument> GetByIdAsync(int id);
        Task<IEnumerable<TDocument>> GetFilteredAsync(Expression<Func<TDocument, bool>> predicate);
    }
}