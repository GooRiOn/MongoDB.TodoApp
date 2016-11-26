using MongoTodo.DataAccess.Documents;
using MongoTodo.DataAccess.Repositories.Interfaces;

namespace MongoTodo.DataAccess.Repositories
{
    internal class CardMongoRepository : MongoRepository<Card>, ICardRepository
    {
        public CardMongoRepository(TodoContext context) : base(context)
        {
        }
    }
}