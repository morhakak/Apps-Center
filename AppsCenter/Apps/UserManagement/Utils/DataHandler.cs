using AppsCenter.Apps.UserManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AppsCenter.Apps.UserManagement.Utils;

public class DataHandler
{
    static readonly string _directory = Directory.GetParent(Environment.CurrentDirectory)!.ToString();
    static readonly string _usersPath = _directory + @"../../../Apps/UserManagement/Data/users.json";
    static readonly string _defaultUsersPath = _directory + @"../../../Apps/UserManagement/Data/DefaultUsers.json";

    public static List<User> GetUsers()
    {
        try
        {
            var _usersJsonString = File.ReadAllText(_usersPath);
            var users = JsonSerializer.Deserialize<List<User>>(_usersJsonString)!;

            return users;
        }
        catch (Exception)
        {
            return new List<User>();
        }
    }

    public static List<User> GetDefaultUsers()
    {
        try
        {
            var _defaultUsersJsonString = File.ReadAllText(_defaultUsersPath);
            var users = JsonSerializer.Deserialize<List<User>>(_defaultUsersJsonString)!;

            return users;
        }
        catch (Exception)
        {
            return new List<User>();
        }
    }

    public static List<User> UpdateList(List<User> usersList)
    {
        string serilized = JsonSerializer.Serialize(usersList);

        File.WriteAllText(_usersPath, serilized);

        var users = GetUsers();
        return users;
    }
}
