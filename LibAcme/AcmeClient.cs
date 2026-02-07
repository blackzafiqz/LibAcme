using System.Net.Http.Json;
using LibAcme.Models;
using Microsoft.Extensions.Logging;
using Directory = LibAcme.Models.Response.Directory;

namespace LibAcme;

public class AcmeClient
{
    private readonly Config _config;
    private readonly HttpClient _httpClient;
    private readonly ILogger _logger;
    public AcmeClient(Config config)
    {
        _config = config;
        _httpClient = new HttpClient();
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = factory.CreateLogger<AcmeClient>();
    }

    public AcmeClient(Config config, HttpClient httpClient)
    {
        _config = config;
        _httpClient = httpClient;
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = factory.CreateLogger<AcmeClient>();
    }
    public AcmeClient(Config config,HttpClient httpClient, ILogger logger)
    {
        _config = config;
        _httpClient = httpClient;
        _logger = logger;
    }
 
}