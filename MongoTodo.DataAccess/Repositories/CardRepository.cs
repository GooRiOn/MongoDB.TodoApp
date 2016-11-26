using MongoTodo.DataAccess.Documents;
using MongoTodo.DataAccess.Repositories.Interfaces;

namespace MongoTodo.DataAccess.Repositories
{
    internal class CardRepository : Repository<Card>, ICardRepository
    {
        public CardRepository(TodoContext context) : base(context)
        {
        }
    }
}