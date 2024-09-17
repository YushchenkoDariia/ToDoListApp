using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return IsCompleted ? $"{Description} (Completed)" : Description;
        }

        public void MarkComplete()
        {
            IsCompleted = true;
        }
    }

}
