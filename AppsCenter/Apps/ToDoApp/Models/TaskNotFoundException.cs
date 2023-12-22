using System;

namespace AppsCenter.Apps.ToDoApp.Models
{
    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException(string message) : base(message) { }
    }
}
