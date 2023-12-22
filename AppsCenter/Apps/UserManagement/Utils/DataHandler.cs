using AppsCenter.Apps.UserManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AppsCenter.Apps.UserManagement.Utils;

public class DataHandler
{
    static readonly string _usersDataRelativePath = Path.Combine("Apps", "UserManagement", "Data", "Users.json");
    static readonly string _usersDataFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _usersDataRelativePath);

    static readonly string _defaultDataRelativePath = Path.Combine("Apps", "UserManagement", "Data", "DefaultUsers.json");
    static readonly string _defaultDataFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _defaultDataRelativePath);

    private static List<User> ReadUsersFromFile(string filePath)
    {
        List<User> users = new();

        try
        {
            var jsonAsString = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<User>>(jsonAsString) ?? new List<User>();
        }
        catch (Exception ex)
        {
            LogError($"Error reading users from {filePath}", ex);
        }

        return users;
    }

    private static void LogError(string message, Exception exception)
    {
        Console.WriteLine($"{message}: {exception.Message}. Creating an empty list.");
    }

    public static List<User> GetUsers()
    {
        return ReadUsersFromFile(_usersDataFullPath);
    }

    public static List<User> GetDefaultUsers()
    {
        return ReadUsersFromFile(_defaultDataFullPath);
    }

    public static List<User> UpdateList(List<User> usersList)
    {
        try
        {
            string jsonAsString = JsonSerializer.Serialize(usersList);
            File.WriteAllText(_usersDataFullPath, jsonAsString);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Unauthorized access to write to file: {_usersDataFullPath}. Users list not updated. Exception: {ex}");
        }
        catch (Exception ex)
        {
            LogError("Error updating users list", ex);
        }

        return usersList;
    }
}
