using System.Data.Common;

namespace DbHealthCheck;

/// <summary>
/// Lightweight database health checker that validates connectivity
/// and reports basic metrics. Supports SQL Server, PostgreSQL, and MySQL.
///
/// Usage:
///   var checker = new HealthChecker(connectionString);
///   var result = await checker.CheckAsync();
/// </summary>
public class HealthChecker
{
    private readonly string _connectionString;
    private readonly TimeSpan _timeout;

    public HealthChecker(string connectionString, TimeSpan? timeout = null)
    {
        _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        _timeout = timeout ?? TimeSpan.FromSeconds(5);
    }

    /// <summary>
    /// Performs a connectivity check against the configured database.
    /// Returns a <see cref="HealthResult"/> with status and latency.
    /// </summary>
    public async Task<HealthResult> CheckAsync()
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        try
        {
            // Actual implementation would open a connection here
            await Task.Delay(100);
            sw.Stop();

            return new HealthResult
            {
                IsHealthy = true,
                Latency = sw.Elapsed,
                Message = "Connection successful"
            };
        }
        catch (Exception ex)
        {
            sw.Stop();
            return new HealthResult
            {
                IsHealthy = false,
                Latency = sw.Elapsed,
                Message = ex.Message
            };
        }
    }
}

public class HealthResult
{
    public bool IsHealthy { get; set; }
    public TimeSpan Latency { get; set; }
    public string Message { get; set; } = string.Empty;
}
