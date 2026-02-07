using LibAcme.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using Directory = LibAcme.Models.Response.Directory;
namespace LibAcme
{
    internal class Acme
    {
        private readonly Config _config;
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private RSA _rsa;
        internal Acme(Config config)
        {
            _config = config;
            _httpClient = new HttpClient();
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            _logger = factory.CreateLogger<AcmeClient>();
        }

        internal Acme(Config config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            _logger = factory.CreateLogger<AcmeClient>();
        }
        internal Acme(Config config, HttpClient httpClient, ILogger logger)
        {
            _config = config;
            _httpClient = httpClient;
            _logger = logger;
        }
        private async Task<Directory> GetDirectory()
        {
            return await _httpClient.GetFromJsonAsync<Directory>(_config.AcmeDirectoryUrl, Utils.JsonOptions)
                   ?? throw new InvalidOperationException("Either your provided AcmeDirectoryUrl is invalid or the ACME server is not responding correctly.");
        }
        public async Task<string?> GetDirectoryTnc()
        {
            var dir = await GetDirectory();
            return dir.Meta?.TermsOfService;
        }
        internal void CreateRsaKeyPair(int keySize)
        {
            _rsa = RSA.Create(keySize);
        }
        internal void CreateEcKeyPair(ECCurve curve)
        {
            
            ECDsa.Create(ECCurve.NamedCurves.nistP256);
        }
    }
}
