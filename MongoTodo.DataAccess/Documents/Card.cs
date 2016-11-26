using System;
using System.Collections.Generic;

namespace MongoTodo.DataAccess.Documents
{
    public class Card : BaseDocument
    {
        public string CreatorFullName { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Task> Tasks { get; set; }
    }
}