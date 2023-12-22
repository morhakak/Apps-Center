﻿using System;

namespace AppsCenter.Apps.UserManagement.Models;

public class User
{
    private static int Count;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime Created { get; set; }

    public User(string name, string email)
    {
        Random random = new();
        Name = name;
        Email = email;
        Password = $"{random.Next(9999)}{Name}{Id}";
        Id = ++Count;
        Created = DateTime.Now;
    }
}
