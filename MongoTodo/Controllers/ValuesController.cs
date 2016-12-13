using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoTodo.DataAccess.Documents;
using MongoTodo.DataAccess.Repositories.Interfaces;
using MongoTodo.Services.Services.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace MongoTodo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ICardService _cardService;

        public ValuesController(ICardService cardService)
        {
            _cardService = cardService;
        }

        // GET api/values
        [HttpGet]
        public async Task Get()
            => await _cardService.InsertOneAsync(new Card
            {
                CreatorFullName = "test",
                CreatedDate = DateTime.Now,
            });

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
