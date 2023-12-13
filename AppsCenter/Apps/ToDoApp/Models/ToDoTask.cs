using System;

namespace AppsCenter.Apps.ToDoApp.Models;

public class ToDoTask
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime CreationTime { get; }
    public bool IsComplete { get; set; }

    public ToDoTask(int id, string description, bool isComplete = false)
    {
        Id = id;
        Description = description;
        IsComplete = isComplete;
        CreationTime = DateTime.Now;
    }
}
