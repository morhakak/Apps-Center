using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace AppsCenter.Apps.ToDoApp.Models;

public class ToDoListModel
{
    public ObservableCollection<ToDoTask> ToDoTasks { get; set; }
    static readonly string _jsonRelativePath = Path.Combine("Apps", "ToDoApp", "todo.json");
    static readonly string _jsonFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _jsonRelativePath);
    private readonly JsonTaskManager _jsonTaskManager;

    public ToDoListModel()
    {
        ToDoTasks = new ObservableCollection<ToDoTask>();
        _jsonTaskManager = new JsonTaskManager(_jsonFullPath);
        LoadTasksFromJson();
    }

    public void UpdateTask(int taskId, string newDescription)
    {
        ToDoTask? task = ToDoTasks.FirstOrDefault(task => task.Id == taskId);

        if (task != null) task.Description = newDescription;

        else throw new Exception("The task with this Id wasn't found");
    }

    public void ToggleTaskIsComplete(int taskId)
    {
        ToDoTask? task = ToDoTasks.FirstOrDefault(task => task.Id == taskId);

        if (task != null) task.IsComplete = !task.IsComplete;

        else throw new TaskNotFoundException("The task with this Id wasn't found");
    }

    public void AddNewTask(ToDoTask task)
    {
        ToDoTasks.Add(task);
    }

    public void RemoveTodoTask(ToDoTask removeTask)
    {
        ToDoTask? task = ToDoTasks.FirstOrDefault(t => t.Id == removeTask.Id);

        if (task != null)
            ToDoTasks.Remove(task);
        else
            throw new TaskNotFoundException($"The task with this Id wasn't found");
    }

    public void SaveTasksToJson()
    {
        _jsonTaskManager.SaveTasks(new List<ToDoTask>(ToDoTasks));
    }

    public void LoadTasksFromJson()
    {
        List<ToDoTask> loadedTasks = _jsonTaskManager.LoadTasks();

        foreach (ToDoTask task in loadedTasks)
        {
            ToDoTasks.Add(task);
        }
    }
}
