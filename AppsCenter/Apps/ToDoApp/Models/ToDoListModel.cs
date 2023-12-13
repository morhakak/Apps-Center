using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace AppsCenter.Apps.ToDoApp.Models;

public class ToDoListModel
{
    public ObservableCollection<ToDoTask> ToDoTasks { get; set; }
    private const string TodoJsonFileName = "C:\\Users\\morh\\Desktop\\C#Projects\\AppsCenter\\AppsCenter\\Apps\\ToDoApp\\todo.json";

    public ToDoListModel()
    {
        ToDoTasks = new ObservableCollection<ToDoTask>();
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

        else throw new Exception("The task with this Id wasn't found");
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
            throw new Exception("The task with this Id wasn't found");
    }

    public void SaveTasksToJson()
    {
        JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
        jsonSerializerOptions.PropertyNameCaseInsensitive = true;

        string json = JsonSerializer.Serialize(ToDoTasks, jsonSerializerOptions);
        File.WriteAllText(TodoJsonFileName, json);
    }

    public void LoadTasksFromJson()
    {
        if (File.Exists(TodoJsonFileName))
        {
            try
            {
                string json = File.ReadAllText(TodoJsonFileName);
                List<ToDoTask> loadedTasks = JsonSerializer.Deserialize<List<ToDoTask>>(json);

                if (loadedTasks != null && loadedTasks.Count > 0)
                {
                    foreach (ToDoTask task in loadedTasks)
                    {
                        ToDoTasks.Add(task);
                    }
                }
                else
                {
                    AddNewTask(new ToDoTask(1, "Do home work", false));
                    AddNewTask(new ToDoTask(2, "Do dishes", false));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks from {TodoJsonFileName}: {ex.Message}");
            }
        }
    }
}
