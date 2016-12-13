using MongoTodo.DataAccess.Documents;
using MongoTodo.DataAccess.Repositories.Interfaces;
using MongoTodo.Services.Services.Interfaces;

namespace MongoTodo.Services.Services
{
    public class CardService : BaseService<Card, ICardRepository>, ICardService
    {
        public CardService(ICardRepository repository) : base(repository)
        {
        }
    }
}