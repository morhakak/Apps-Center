using AppsCenter.Apps.CurrencyConverter.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppsCenter.Apps.CurrencyConverter.Services;

public class CurrencyService
{
    private readonly IConfiguration _configuration = new ConfigurationBuilder().AddUserSecrets<CurrencyService>().Build();
    private const string _baseApiEndPoint = "http://api.exchangeratesapi.io/v1/latest";

    public async Task<Dictionary<string, double>> GetExchangeRatesAysnc()
    {
        string apiKey = _configuration["ApiKey"];

        if (string.IsNullOrEmpty(apiKey))
            throw new InvalidOperationException("API key is missing or invalid.");

        try
        {
            string request = $"{_baseApiEndPoint}?access_key={apiKey}";

            using var client = new HttpClient();

            var response = await client.GetStringAsync(request);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var exchange = JsonSerializer.Deserialize<ExchangeResponse>(response, options);

            if (exchange == null || exchange.Rates == null)
                throw new InvalidOperationException("Failed to fetch exchange rates" + response);

            return exchange.Rates;
        }
        catch (HttpRequestException ex)
        {
            throw new InvalidOperationException("Failed to fetch exchange rates. See logs for details.", ex);
        }
    }
}
