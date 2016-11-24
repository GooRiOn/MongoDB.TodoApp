using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoTodo.DataAccess.Models
{
    public class Card
    {
        [BsonId]
        public int Id { get; set; }

        public string CreatorFullName { get; set; }

        public DateTime CreatedDate { get; set; }

        public IEnumerable<Task> Tasks { get; set; }
    }
}