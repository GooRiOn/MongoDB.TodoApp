using MongoTodo.DataAccess.Documents;
using MongoTodo.DataAccess.Repositories.Interfaces;

namespace MongoTodo.DataAccess.Repositories
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        internal CardRepository(TodoContext context) : base(context)
        {
        }
    }
}