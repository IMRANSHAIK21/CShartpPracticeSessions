using Microsoft.Extensions.Configuration;

var builer = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddUserSecrets<Program>();

IConfiguration configuration = builer.Build(); // it will the configuration builder

Console.WriteLine(configuration.GetValue<int>("StarterCounter") + 6); // accessing values
Console.WriteLine(configuration.GetValue<string>("User:FirstName"));

// pustting secret values in json
// what if we want to store the secret values like passwords etc
// it should only accessible by me
Console.WriteLine($"My Secret value: {configuration.GetValue<string>("MySecretValue")}");
