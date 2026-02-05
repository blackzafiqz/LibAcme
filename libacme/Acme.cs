using System.Net.Http.Json;
using LibAcme.Models;
using Microsoft.Extensions.Logging;
using Directory = LibAcme.Models.Response.Directory;

namespace LibAcme;

public class Acme
{
    private readonly Config _config;
    private readonly HttpClient _httpClient;
    private readonly ILogger _logger;
    private readonly Directory _directory;
    public Acme(Config config)
    {
        _config = config;
        _httpClient = new HttpClient();
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = factory.CreateLogger<Acme>();
    }

    public Acme(Config config, HttpClient httpClient)
    {
        _config = config;
        _httpClient = httpClient;
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = factory.CreateLogger<Acme>();
    }
    public Acme(Config config,HttpClient httpClient, ILogger logger)
    {
        _config = config;
        _httpClient = httpClient;
        _logger = logger;
    }
    private async Task<Directory> GetDirectory()
    {
        return await _httpClient.GetFromJsonAsync<Directory>(_config.AcmeDirectoryUrl,Utils.JsonOptions) 
               ?? throw new InvalidOperationException("Either your provided AcmeDirectoryUrl is invalid or the ACME server is not responding correctly.");
    }
    public Task <string> GetDirectoryTnc()
    {
        _httpClient.GetAsync()
    }
}