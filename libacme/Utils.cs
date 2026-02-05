using System.Text.Json;

namespace LibAcme;

internal static class Utils
{
    internal static JsonSerializerOptions JsonOptions => new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
    };
}