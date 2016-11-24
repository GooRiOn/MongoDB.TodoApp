using System;

namespace MongoTodo.DataAccess.Models
{
    public class Task
    {
        public string Description { get; set; }

        public bool IsDone { get; set; }

        public DateTime Deadline { get; set; }
    }
}