using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WebSiteTest.Utils;

public static class ConfigWork
{
    private static readonly Dictionary<string, string>? ConfDict =
        JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("../../../Configs/config.json"));
    
    private static readonly Dictionary<string, string>? TestDict =
        JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("../../../Configs/testData.json"));

    public static string GetFromConfig(string key)
    {
        return ConfDict?[key] ?? string.Empty;
    }

    public static string GetFromTestData(string key)
    {
        return TestDict?[key] ?? string.Empty;
    }
}