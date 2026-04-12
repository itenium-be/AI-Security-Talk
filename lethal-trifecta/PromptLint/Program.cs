using Microsoft.Extensions.Configuration;

namespace PromptLint;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var apiKey = config["OpenAI:ApiKey"];
        Console.WriteLine("PromptLint — linting LLM prompts for common issues");
        Console.WriteLine($"OpenAI: {(apiKey != null ? "configured" : "missing")}");
    }
}
