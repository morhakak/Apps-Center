using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace AppsCenter.Helpers;

public class DataReader
{
    static readonly string _relativePath = Path.Combine("Helpers", "data.json");
    static readonly string _fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _relativePath);

    public static AppInfo GetAppByName(string appName)
    {
        List<AppInfo> appInfoList = ReadAppData();

        if (appInfoList != null)
        {
            AppInfo appInfo = new();

            appInfo = appInfoList.FirstOrDefault(app => app.AppTitle.Equals(appName, StringComparison.OrdinalIgnoreCase));
            return appInfo;
        }

        return null;
    }

    private static List<AppInfo> ReadAppData()
    {
        try
        {
            string jsonString = File.ReadAllText(_fullPath);
            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
            };

            List<AppInfo> appInfoList = JsonSerializer.Deserialize<List<AppInfo>>(jsonString, options);
            return appInfoList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading JSON file: {ex.Message}");
            return null;
        }
    }
}
