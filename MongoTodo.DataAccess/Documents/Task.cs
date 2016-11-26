using System;

namespace MongoTodo.DataAccess.Documents
{
    public class Task
    {
        public string Description { get; set; }

        public bool IsDone { get; set; }

        public DateTime Deadline { get; set; }
    }
}