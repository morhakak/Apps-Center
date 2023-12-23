using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AppsCenter.Apps.ToDoApp.Models
{
    public class JsonTaskManager
    {
        private readonly string _filePath;

        public JsonTaskManager(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
            EnsureDirectoryExists();
        }

        public List<ToDoTask> LoadTasks()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    return JsonSerializer.Deserialize<List<ToDoTask>>(json) ?? new List<ToDoTask>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks from {_filePath}: {ex.Message}");
            }

            return new List<ToDoTask>();
        }

        public void SaveTasks(List<ToDoTask> tasks)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new()
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(tasks, jsonSerializerOptions);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks to {_filePath}: {ex.Message}");
            }
        }

        private void EnsureDirectoryExists()
        {
            string directoryPath = Path.GetDirectoryName(_filePath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}
