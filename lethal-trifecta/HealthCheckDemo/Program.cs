using Microsoft.Extensions.Configuration;

namespace HealthCheckDemo;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");
        Console.WriteLine("Starting health checks...");

        // TODO: integrate DbHealthCheck library
        Console.WriteLine($"Database: {(connectionString != null ? "configured" : "missing")}");
    }
}
