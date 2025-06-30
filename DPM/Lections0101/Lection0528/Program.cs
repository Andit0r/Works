using System.Configuration;
using System.Text.Json;

Console.WriteLine("settings");
// json
string fileName = "users.json";
string json = File.ReadAllText(fileName);

JsonSerializerOptions options = new()
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

var users = JsonSerializer.Deserialize<List<User>>(json, options);

options = new()
{
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};
json = JsonSerializer.Serialize(users, options);

var login = ConfigurationManager.AppSettings["Login"];

var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
config.AppSettings.Settings["Login"].Value = "менеджер";
config.Save();
ConfigurationManager.RefreshSection("appSettings");

login = ConfigurationManager.AppSettings["Login"];





Console.WriteLine();