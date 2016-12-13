using System.Threading.Tasks;
using MongoDB.Driver;
using MongoTodo.DataAccess.Documents.Interfaces;

namespace MongoTodo.DataAccess.Repositories.Interfaces
{
    public interface IRepository<TDocument> where TDocument : IBaseDocument
    {
        Task InsertOneAsync(TDocument document);
        Task<TDocument> GetByIdAsync(int id);
    }
}