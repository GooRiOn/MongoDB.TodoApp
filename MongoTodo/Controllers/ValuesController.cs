using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoTodo.DataAccess.Documents;
using MongoTodo.DataAccess.Repositories.Interfaces;
using Task = MongoTodo.DataAccess.Documents.Task;

namespace MongoTodo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        ICardRepository CardRepository { get; }

        public ValuesController(ICardRepository cardRepository)
        {
            CardRepository = cardRepository;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> GetAsync()
        {
            await CardRepository.InsertOneAsync(new Card
            {
                CreatedDate = DateTime.Now,
                CreatorFullName = "Tomasz Zapiec",
                Tasks = new List<Task>
                {
                    new Task {Deadline = DateTime.Today,Description = "test"}
                }
            });

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
